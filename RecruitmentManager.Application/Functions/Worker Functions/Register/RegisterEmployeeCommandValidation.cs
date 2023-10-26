using FluentValidation;
using RecruitmentManager.Application.Regex_Patterns;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Register;

public class RegisterEmployeeCommandValidation
	: AbstractValidator<RegisterEmployeeCommand>
{
	public RegisterEmployeeCommandValidation()
	{
		RuleFor(x => x.Email)
			.Cascade(CascadeMode.Stop)
			.NotEmpty()
			.WithMessage("Pusty adres Email!")
			.Must(email => new EmailValidation().IsValid(email))
			.WithMessage("Nieprawidłowy adres email!");
		RuleFor(x => x.Password)
			.Cascade(CascadeMode.Stop)
			.NotEmpty()
			.WithMessage("Puste hasło!")
			.MinimumLength(8)
			.WithMessage("Hasło powinno zawierać conajmniej 8 znaków!");
	}
}
