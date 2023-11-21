using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Interfaces.Context;

public interface IAssessmentCandidate
{
	Guid CandidateId { get; }
	Guid JobApplicationId { get; }
	void Clear();
	void Set(Guid candidateId, Guid jobApplicationId);
}