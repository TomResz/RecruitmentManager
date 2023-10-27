using FluentValidation;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ResetPassword;

public class CandidateResetPasswordCommandValidation
	: AbstractValidator<CandidateResetPasswordCommand>
{
    public CandidateResetPasswordCommandValidation()
    {
        RuleFor(x=>x.Password)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Hasło nie może być puste!")
            .MinimumLength(8)
            .WithMessage("Hasło musi mieć conajmniej 8 znaków!")
            .Equal(x=>x.ConfirmedPassword)
            .WithMessage("Hasła do siebie nie pasują!");
    }
}
