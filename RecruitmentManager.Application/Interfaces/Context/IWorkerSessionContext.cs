using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Interfaces.Context;

public interface IWorkerSessionContext
{
	Guid? WorkerId { get; }
	string FullName { get; }
	Roles GetRole { get; }
	void SetWorker(Guid Id, Roles role, string FullName);
	void Logout();
}
