using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface ICandidateRatingRepository : IAsyncRepository<CandidateRating>
{
	Task AddRange(IEnumerable<CandidateRating> candidateRatings);
	Task<List<CandidateRating>> GetNotSetInterview();
	Task<List<CandidateRating>> GetSetInterviewByRecruiterId(Guid recruiterId);
	Task<List<CandidateRating>> GetByRecruiterId(Guid recruiterId);
	Task<List<CandidateRating>> GetAllWithDate();
	Task<bool> ExistsInterviewsForCandidateDuringThisTime(CandidateRating candidateRating, DateTime date);
	Task<bool> ExistsInterviewsForRecruiterDuringThisTime(CandidateRating candidateRating, DateTime date);
	Task<List<CandidateRating>> GetRatingsForCandidateApplicationTask(Guid candidateRatingId,Guid candidateId);
	Task<List<CandidateRating>> GetFullDataByCandidateId(Guid candidateId);
	Task UpdateRange(List<CandidateRating> candidates);
}