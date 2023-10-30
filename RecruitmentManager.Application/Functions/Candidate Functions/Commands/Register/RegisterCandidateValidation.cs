using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Register;

public class RegisterCandidateValidation
	: AbstractValidator<RegisterCandidateCommand>
{
	public RegisterCandidateValidation()
	{
		RuleFor(x=>x.FirstName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("imię");
		RuleFor(x => x.LastName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("nazwisko");
		RuleFor(x => x.Email)
			.Cascade(CascadeMode.Stop)
			.EmailMustBeValid();
		RuleFor(x => x.Password)
			.Cascade(CascadeMode.Stop)
			.PasswordMustBeValid();
		RuleFor(x => x.ConfirmedPassword)
			.Equal(x => x.Password)
			.WithMessage("Drugie hasło nie pasuje!");
	}
}
