using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IKnowledgeOfLanguageRepository
{
	Task<List<KnowledgeOfLanguage>> GetAllByCandidateId(Guid CandidateId);
}