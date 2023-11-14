using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface ISkillRepository
{
	Task<List<Skill>> GetByCandidateIdList(Guid CandidateId);
}