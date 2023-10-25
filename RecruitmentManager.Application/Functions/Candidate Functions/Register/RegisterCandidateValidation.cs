using FluentValidation;
using RecruitmentManager.Application.Regex_Patterns;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Register;

public class RegisterCandidateValidation
	: AbstractValidator<RegisterCandidateCommand>
{
	public RegisterCandidateValidation()
	{
		RuleFor(x => x.Email)
			.Cascade(CascadeMode.Stop)
			.NotNull()
			.NotEmpty()
			.WithMessage("Pusty email!")
			.Must(email => new EmailValidation().IsValid(email) == true)
			.WithMessage("Nieprawidłowy email!");
		RuleFor(x => x.Password)
			.NotNull()
			.NotEmpty()
			.WithMessage("Puste hasło!");
		RuleFor(x => x.ConfirmedPassword)
			.Equal(x => x.Password)
			.WithMessage("Drugie hasło nie pasuje!");
	}
}
