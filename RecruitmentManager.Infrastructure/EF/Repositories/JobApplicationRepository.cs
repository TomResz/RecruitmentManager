using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class JobApplicationRepository : IJobApplicationRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public JobApplicationRepository(
		RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task<bool> Exists(Guid jobPostingId, Guid candidateId)
	{
		var result = await _context
			.JobApplications
			.AsNoTracking()
			.FirstOrDefaultAsync(x=>x.CandidateId == candidateId
				&& x.JobPostingId == jobPostingId);
		return result is not null;
	}

	public async Task Add(JobApplication jobApplication)
	{
		await _context
			.JobApplications
			.AddAsync(jobApplication);
		await _context.SaveChangesAsync();
	}
}