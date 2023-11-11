using FluentValidation;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Add;

public class AddLanguageCommandValidation
	: AbstractValidator<AddLanguageCommand>
{
	public AddLanguageCommandValidation()
	{
		RuleFor(x => x.Language)
			.NotEmpty().WithMessage("Pole nie może być puste!");
	}
}