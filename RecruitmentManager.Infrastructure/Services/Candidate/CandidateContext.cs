using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Infrastructure.Services.Candidate;

public class CandidateContext : ICandidateContext
{
	private Guid _id { get; set; } = Guid.Empty;
	public void SetId(Guid id)
	{
		_id = id;
	}

	public Guid Id => _id;
	public void Logout()
	{
		_id = Guid.Empty;
	}
}