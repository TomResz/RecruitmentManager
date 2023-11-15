namespace RecruitmentManager.Application.Interfaces.Context;

public interface ICandidateContext
{
	void SetId(Guid id);
	Guid Id { get; }
	void Logout();
}