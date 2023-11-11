using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class KnowledgeOfLanguageRepository
	: IKnowledgeOfLanguageRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public KnowledgeOfLanguageRepository(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task<List<KnowledgeOfLanguage>> GetAllByCandidateId(Guid CandidateId)
	{
		return await _context
			.KnowledgeOfLanguages
			.Where(x => x.CandidateId == CandidateId)
			.ToListAsync();
	}
}