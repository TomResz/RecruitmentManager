namespace RecruitmentManager.Application.Interfaces.Context;

public interface ICandidateSessionContext
{
	Guid? CandidateId { get; }
	void SetId(Guid candidateId);
	void Logout();
}
