using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Infrastructure.Services.Common;

public class UserDataToEditContext
    : IUserDataToEditContext
{
    private Guid _uid = Guid.Empty;
    private string _email = string.Empty;

    public Guid GetId => _uid;

    public string GetEmail => _email;

    public void Clear()
    {
        _email = "";
        _uid = Guid.Empty;
    }

    public void SetData(Guid id, string Email)
    {
        _uid = id;
        _email = Email;
    }
}
