using FluentValidation;
using RecruitmentManager.Application.Regex_Patterns;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.CreateWorker;

public class CreateWorkerCommandValidation
	: AbstractValidator<CreateWorkerCommand>
{
	public CreateWorkerCommandValidation()
	{
		RuleFor(x => x.FirstName)
			.NotEmpty()
			.WithMessage("Puste imię!");
		RuleFor(x => x.LastName)
		   .NotEmpty()
		   .WithMessage("Puste nazwisko!");
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
			.Equal(x => x.ConfirmedPassword)
			.WithMessage("Nieprawidło drugie hasło!")
			.MinimumLength(8)
			.WithMessage("Nieprawidłowa długość hasła!");
	}
}
