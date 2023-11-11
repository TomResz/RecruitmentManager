using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IHobbyRepository
{
	Task<List<Hobby>> GetAllByCandidateId(Guid CandidateId);
}