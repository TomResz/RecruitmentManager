namespace RecruitmentManager.Application.Interfaces.Context;

public interface IUserBasicDataContext
{
	Guid GetId { get; }
	string GetEmail { get; }
	void SetData(Guid id, string Email);
	void Clear();
}
