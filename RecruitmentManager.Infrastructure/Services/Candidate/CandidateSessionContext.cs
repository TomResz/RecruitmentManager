using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Infrastructure.Services.Candidate;

public class CandidateSessionContext
    : ICandidateSessionContext
{
    private Guid? _sessionId = null;
    public Guid? CandidateId => _sessionId;

    public void Logout()
    {
        _sessionId = Guid.Empty;
    }

    public void SetId(Guid candidateId)
    {
        _sessionId = candidateId;
    }
}
