using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class RecruitmentStageRepository : AsyncRepository<RecruitmentStage>,IRecruitmentStageRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public RecruitmentStageRepository(
		RecruitmentManagerDbContext context) : base(context)
	{
		_context = context;
	}

	public async Task<List<RecruitmentStage>> GetByJobPostingId(
		Guid jobPostingId)
	{
		return await _context
			.RecruitmentStages
			.Include(x => x.Employee)
			.Where(x => x.JobPostingId == jobPostingId)
			.ToListAsync();
	}
}