using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IEducationRepository : IAsyncRepository<Education>
{
	Task<List<Education>> GetEducationListByCandidateId(Guid CandidateId);
}