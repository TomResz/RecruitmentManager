using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface ICandidateRepository : IAsyncRepository<Candidate>
{
	Task<Candidate?> GetFullWithPBData(Guid Id, CancellationToken cancellationToken = default);
	Task<List<Candidate>> GetByJobPostingId(Guid jobPostingId);
	Task<Candidate?> GetFullData(Guid CandidateId, CancellationToken cancellationToken = default);
	Task<Candidate?> GetByEmailAsync(string email);

	Task<List<EvaluatedCandidateDto>> GetListByJobPostingsWithRating(Guid JobPostingId);
}
