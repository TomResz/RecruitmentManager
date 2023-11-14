using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class SkillRepository : ISkillRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public SkillRepository(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task<List<Skill>> GetByCandidateIdList(Guid CandidateId)
	{
		return await _context
			.Skills
			.Where(x=>x.CandidateId == CandidateId)
			.AsNoTracking()
			.ToListAsync();
	}
}