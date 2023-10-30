using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.CreateWorker;

public class CreateWorkerCommandValidation
	: AbstractValidator<CreateWorkerCommand>
{
	public CreateWorkerCommandValidation()
	{
		RuleFor(x => x.FirstName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("imię");
		RuleFor(x => x.LastName)
			.NameMustBeValid("nazwisko");
		RuleFor(x => x.Email)
			.Cascade(CascadeMode.Stop)
			.EmailMustBeValid();
		RuleFor(x => x.Password)
			.Cascade(CascadeMode.Stop)
			.PasswordMustBeValid()
			.Equal(x => x.ConfirmedPassword)
			.WithMessage("Nieprawidło drugie hasło!");
	}
}
