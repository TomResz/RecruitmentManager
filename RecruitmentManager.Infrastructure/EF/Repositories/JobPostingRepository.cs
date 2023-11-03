using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class JobPostingRepository : IJobPostingRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public JobPostingRepository(
		RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(JobPosting entity)
	{
		await _context.JobPostings.AddAsync(entity);
		await _context.SaveChangesAsync();
	}
}