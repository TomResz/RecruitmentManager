using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Login;

public class LoginWorkerCommandValidation 
	: AbstractValidator<LoginWorkerCommand>
{
    public LoginWorkerCommandValidation()
    {
        RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .EmailMustBeValid();
        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .PasswordMustBeValid();
    }
}
