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
			.Where(x=>x.InterviewDate != null)
			.Include(x => x.RecruitmentStage)
			.ThenInclude(x => x.Employee)
			.Include(x=>x.Candidate)
			.ThenInclude(x=>x.CandidateData)
			.AsNoTracking()
			.ToListAsync();
	}
}