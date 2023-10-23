using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Infrastructure.Services.Candidate;

public class WorkerSessionContext
	: IWorkerSessionContext
{
	private Guid? _sessionId = null;
	private Roles? _sessionRole = null;
	public Guid? WorkerId => _sessionId;

	public Roles? GetRole => _sessionRole;

	public void Logout()
	{
		_sessionId = Guid.Empty;
		_sessionRole = null;
	}

	public void SetId(Guid candidateId)
	{
		_sessionId = candidateId;
	}

	public void SetRole(Roles role)
	{
		_sessionRole = role;
	}
}
