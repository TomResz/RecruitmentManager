using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class CandidateRatingRepository : AsyncRepository<CandidateRating>,ICandidateRatingRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public CandidateRatingRepository(RecruitmentManagerDbContext context) : base(context)
	{
		_context = context;
	}

	public async Task AddRange(IEnumerable<CandidateRating> candidateRatings)
	{
		await _context
			.CandidateRatings
			.AddRangeAsync(candidateRatings);
		await _context.SaveChangesAsync();
	}

	public async Task<List<CandidateRating>> GetNotSetInterview()
	{
		return await _context
			.CandidateRatings
			.Where(x=>x.InterviewDate == null)
			.Include(x => x.Candidate)
			.ThenInclude(x => x.CandidateData)
			.Include(x => x.RecruitmentStage)
			.ThenInclude(x => x.JobPosting)
			.AsNoTracking()
			.ToListAsync();
	}

	public async Task<List<CandidateRating>> GetSetInterviewByRecruiterId(Guid recruiterId)
	{
		return await _context
			.CandidateRatings
			.Where(x => x.InterviewDate != null 
			            && x.RecruitmentStage.EmployeeId == recruiterId)
			.Include(x => x.Candidate)
			.ThenInclude(x => x.CandidateData)
			.Include(x => x.RecruitmentStage)
			.ThenInclude(x => x.JobPosting)
			.AsNoTracking()
			.ToListAsync();
	}

	public async Task<List<CandidateRating>> GetByRecruiterId(Guid recruiterId)
	{
		return await _context
			.CandidateRatings
			.Where(x=>x.InterviewDate != null && x.RecruitmentStage.EmployeeId == recruiterId)
			.Include(x => x.RecruitmentStage)
			.ThenInclude(x=>x.JobPosting)
			.ThenInclude(x => x.Employee)
			.Include(x=>x.Candidate)
			.ThenInclude(x=>x.CandidateData)
			.AsNoTracking()
			.ToListAsync();
	}

	public async Task<List<CandidateRating>> GetAllWithDate()
	{
		return await _context
			.CandidateRatings
			.Where(x => x.InterviewDate != null)
			.Include(x => x.Candidate)
			.ThenInclude(x => x.CandidateData)
			.Include(x => x.RecruitmentStage)
			.ThenInclude(x => x.JobPosting)
			.AsNoTracking()
			.ToListAsync();
	}

	public async Task<bool> ExistsInterviewsForCandidateDuringThisTime(CandidateRating candidateRating, DateTime date)
	{
		DateTime startTime = date.AddHours(-1).AddSeconds(-1);
		DateTime endTime = date.AddHours(1).AddSeconds(-1);

		bool existsInterviews = await _context
			.CandidateRatings
			.AnyAsync(cr =>
				cr.CandidateId == candidateRating.CandidateId &&
				cr.InterviewDate.HasValue &&
				cr.InterviewDate.Value >= startTime &&
				cr.InterviewDate.Value <= endTime &&
				cr.Id != candidateRating.Id);
		return existsInterviews;
	}

	public async Task<bool> ExistsInterviewsForRecruiterDuringThisTime(CandidateRating candidateRating, DateTime date)
	{
		DateTime startTime = date.AddHours(-1).AddSeconds(-1);
		DateTime endTime = date.AddHours(1).AddSeconds(-1);

		var employeeId = await _context
			.RecruitmentStages
			.Where(x=>x.Id == candidateRating.RecruitmentStageId)
			.AsNoTracking()
			.Select(x => x.EmployeeId)
			.FirstOrDefaultAsync();

		var mettingsAtThisTime = await _context
			.CandidateRatings
			.Include(x => x.RecruitmentStage)
			.AnyAsync(x => x.RecruitmentStage.EmployeeId == employeeId &&
			               x.InterviewDate.HasValue &&
			               x.InterviewDate.Value >= startTime &&
			               x.InterviewDate.Value <= endTime &&
			               x.Id != candidateRating.Id);
		return mettingsAtThisTime;
	}
}