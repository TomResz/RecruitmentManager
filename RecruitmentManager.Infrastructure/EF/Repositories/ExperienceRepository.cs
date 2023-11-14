using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class ExperienceRepository : IExperienceRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public ExperienceRepository(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task<List<Experience>> GetByCandidateIdWithoutTracking(Guid CandidateId, CancellationToken cancellationToken = default)
	{
		return await _context
			.Experiences
			.Where(x => x.CandidateId == CandidateId)
			.AsNoTracking()
			.ToListAsync(cancellationToken: cancellationToken);
	}
}