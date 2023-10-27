namespace RecruitmentManager.Application.Interfaces.Context;

public interface IUserDataToEditContext
{
	Guid GetId { get; }
	string GetEmail { get; }
	void SetData(Guid id, string Email);
	void Clear();
}
