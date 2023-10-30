using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ResetPassword;

public class CandidateResetPasswordCommandValidation
	: AbstractValidator<CandidateResetPasswordCommand>
{
    public CandidateResetPasswordCommandValidation()
    {
        RuleFor(x=>x.Password)
            .Cascade(CascadeMode.Stop)
            .PasswordMustBeValid()
            .Equal(x=>x.ConfirmedPassword)
            .WithMessage("Hasła do siebie nie pasują!");
    }
}
