using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface ICandidateRatingRepository : IAsyncRepository<CandidateRating>
{
	Task AddRange(IEnumerable<CandidateRating>  candidateRatings);
	Task<List<CandidateRating>> GetNotSetInterview();
	Task<List<CandidateRating>> GetSetInterviewByRecruiterId(Guid recruiterId);
	Task<List<CandidateRating>> GetByRecruiterId(Guid recruiterId);
	Task<List<CandidateRating>> GetAllWithDate();
}