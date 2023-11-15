using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class JobPostingRepository 
	: AsyncRepository<JobPosting> , IJobPostingRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public JobPostingRepository(
		RecruitmentManagerDbContext context) : base(context)
	{
		_context = context;
	}


	public async Task AddAsync(JobPosting entity)
	{
		await _context.JobPostings.AddAsync(entity);
		await _context.SaveChangesAsync();
	}

	public async Task<JobPosting?> GetFullDataByIdAsync(
		Guid id)
	{
		return await _context
			.JobPostings
			.AsNoTracking()
			.Include(x => x.RecruitmentStages)
			.ThenInclude(x=>x.Employee)
			.ThenInclude(x=>x.EmployeeData)
			.FirstOrDefaultAsync(x => x.Id == id);
	}

	public async Task UpdateWithRecruitmentStage(
		JobPosting entity)
	{
		using (var transaction = _context.Database.BeginTransaction())
		{
			try
			{
				var recruitmentStagesToDelete = _context
					.RecruitmentStages
					.Include(x => x.JobPosting)
					.Where(x => x.JobPosting.Id == entity.Id)
					.ToList();
				_context
					.RecruitmentStages
					.RemoveRange(recruitmentStagesToDelete);
				await _context.SaveChangesAsync();

				var stages = new List<RecruitmentStage>();
				foreach (var stage in entity.RecruitmentStages)
				{
					var newStage = new RecruitmentStage()
					{
						StageName = stage.StageName,
						EmployeeId = stage.EmployeeId,
						GradeWeight = stage.GradeWeight,
						JobPostingId = entity.Id,
						Id = stage.Id,
						Order = stage.Order
					};
					stages.Add(newStage);
				}
				await _context.RecruitmentStages.AddRangeAsync(stages);
				await _context.SaveChangesAsync();

				var tmp = await _context
					.JobPostings
					.FirstAsync(x => x.Id == entity.Id);
				entity.RecruitmentStages.Clear();
				_context.Entry(tmp).CurrentValues.SetValues(entity);
				await _context.SaveChangesAsync();
				transaction.Commit();
			}
			catch (Exception)
			{
				transaction.Rollback();
				throw;
			}
		}
	}

	public async Task<List<JobPosting>> GetWithJobApplicationWhereDidNotApply(
		Guid candidateId)
	{
		return await _context
			.JobPostings
			.Include(x => x.JobApplications)
			.Where(x => x.JobApplications.All(y => y.CandidateId != candidateId))
			.AsNoTracking()
			.ToListAsync();
	}

	public async Task<List<JobPosting>> GetWithJobApplicationWhereApply(
		Guid candidateId)
	{
		return await _context
			.JobPostings
			.Include(x => x.JobApplications)
			.Where(x => x.JobApplications.Any(x => x.CandidateId == candidateId))
			.ToListAsync();
	}
}