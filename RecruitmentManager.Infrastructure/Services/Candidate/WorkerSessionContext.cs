using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Infrastructure.Services.Candidate;

public class WorkerSessionContext
    : IWorkerSessionContext
{
    private Guid? _sessionId = null;
    private Roles? _sessionRole = null;
    private string _fullName = "";


    public Guid? WorkerId => _sessionId;

    public Roles? GetRole => _sessionRole;

    public string FullName => _fullName;

	public void Logout()
    {
        _sessionId = Guid.Empty;
        _sessionRole = null;
        _fullName = "";
    }

	public void SetWorker(Guid Id, Roles role, string FullName)
	{
        _sessionId = Id;
        _sessionRole = role;
        _fullName = FullName;
	}
}
