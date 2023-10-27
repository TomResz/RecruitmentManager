using FluentValidation;
using RecruitmentManager.Application.Regex_Patterns;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Login;

public class LoginCandidateCommandValidation
	: AbstractValidator<LoginCandidateCommand>
{
    public LoginCandidateCommandValidation()
    {
        RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Pusty Email!")
            .Must(email=> new EmailValidation().IsValid(email))
            .WithMessage("Nieprawidłowy adres Email!");
        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Puste hasło")
            .MinimumLength(8)
            .WithMessage("Nieprawidłowa długość hasła!");
    }
}
