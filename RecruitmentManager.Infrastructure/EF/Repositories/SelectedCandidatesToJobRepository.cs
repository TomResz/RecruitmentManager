using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class SelectedCandidatesToJobRepository : ISelectedCandidatesToJobRepository
{
	private readonly RecruitmentManagerDbContext _dbContext;

	public SelectedCandidatesToJobRepository(RecruitmentManagerDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task Add(List<SelectedCandidatesToJob> selectedCandidatesToJobs)
	{
		await _dbContext
			.SelectedCandidatesToJobs
			.AddRangeAsync(selectedCandidatesToJobs);
		await _dbContext.SaveChangesAsync();
	}

	public async Task Remove(Guid JobPostingId)
	{
		var list = await _dbContext
			.SelectedCandidatesToJobs
			.Where(x=>x.JobPostingId == JobPostingId)
			.ToListAsync();
		_dbContext.RemoveRange(list);
		await _dbContext.SaveChangesAsync();
	}
}
