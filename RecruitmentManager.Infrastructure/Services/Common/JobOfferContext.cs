using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Infrastructure.Services.Common;

public class JobOfferContext : IJobOfferContext
{
	private Guid _id = Guid.Empty;
	public void SetId(Guid id)
	{
		_id = id;
	}

	public Guid Id => _id;
	public void Clear() => _id = Guid.Empty;
}