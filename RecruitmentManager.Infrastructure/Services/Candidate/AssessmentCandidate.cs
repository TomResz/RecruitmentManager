using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Infrastructure.Services.Candidate;

public class AssessmentCandidate : IAssessmentCandidate
{
	private Guid _jobApplicationId = Guid.Empty;
	private Guid _candidateId = Guid.Empty;

	public Guid CandidateId  => _candidateId;
	public Guid JobApplicationId => _jobApplicationId;
	public void Clear()
	{
		_jobApplicationId = Guid.Empty;
		_candidateId = Guid.Empty;
	}

	public void Set(Guid candidateId, Guid jobApplicationId)
	{
		_jobApplicationId = jobApplicationId;
		_candidateId = candidateId;
	}
}