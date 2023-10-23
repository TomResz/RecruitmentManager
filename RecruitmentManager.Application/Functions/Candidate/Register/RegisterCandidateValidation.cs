using FluentValidation;
using RecruitmentManager.Application.Regex_Patterns;

namespace RecruitmentManager.Application.Functions.Candidate.Register;

public class RegisterCandidateValidation
    : AbstractValidator<RegisterCandidateCommand>
{
    public RegisterCandidateValidation()
    {
        RuleFor(x => x.Email)
            .NotNull()
            .NotEmpty()
            .WithMessage("Pusty email!")
            .Must(email => new EmailValidation().IsValid(email) == true)
            .WithMessage("Nie prawidłowy email!");

        RuleFor(x => x.Password)
            .NotNull()
            .NotEmpty()
            .WithMessage("Puste hasło!");
        RuleFor(x => x.ConfirmedPassword)
            .Equal(x => x.Password)
            .WithMessage("Drugie hasło nie pasuje!");
    }
}
