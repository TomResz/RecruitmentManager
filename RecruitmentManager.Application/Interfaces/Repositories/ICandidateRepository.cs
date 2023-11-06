using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface ICandidateRepository : IAsyncRepository<Candidate>
{
	Task<Candidate?> GetFullData(Guid Id, CancellationToken cancellationToken = default);
	Task<Candidate?> GetByEmailAsync(string email);
}
