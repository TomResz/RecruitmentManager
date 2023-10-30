using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Login;

public class LoginCandidateCommandValidation
	: AbstractValidator<LoginCandidateCommand>
{
    public LoginCandidateCommandValidation()
    {
        RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .EmailMustBeValid();
        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .PasswordMustBeValid();
    }
}
