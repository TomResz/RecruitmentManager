using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface ICandidateRepository : IAsyncRepository<Candidate>
{
	Task<Candidate?> GetByEmailAsync(string email);
}
