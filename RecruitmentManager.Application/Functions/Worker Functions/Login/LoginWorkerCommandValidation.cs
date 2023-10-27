using FluentValidation;
using RecruitmentManager.Application.Regex_Patterns;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Login;

public class LoginWorkerCommandValidation 
	: AbstractValidator<LoginWorkerCommand>
{
    public LoginWorkerCommandValidation()
    {
        RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Pusty adres email!")
            .Must(email => new EmailValidation().IsValid(email))
            .WithMessage("Nieprawidłowy adres email!");
        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Puste hasło!")
            .MinimumLength(8)
            .WithMessage("Nieprawidłowa długość hasła!");
    }
}
