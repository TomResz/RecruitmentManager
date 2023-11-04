namespace RecruitmentManager.Application.Interfaces.Context;

public interface IJobOfferContext
{
	void SetId(Guid id);
	Guid Id { get; }
	void Clear();

}