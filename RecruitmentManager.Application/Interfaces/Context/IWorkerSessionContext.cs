using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Interfaces.Context;

public interface IWorkerSessionContext
{
	Guid? WorkerId { get; }
	
	Roles? GetRole { get; }
	void SetId(Guid candidateId);
	void SetRole(Roles role);	
	void Logout();
}
