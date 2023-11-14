using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IExperienceRepository
{
	Task<List<Experience>> GetByCandidateIdWithoutTracking(Guid CandidateId,CancellationToken cancellationToken=default); 
}