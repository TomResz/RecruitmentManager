using FluentValidation;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Update;

public class UpdateLanguageCommandValidator
	: AbstractValidator<UpdateLanguageCommand>
{
	public UpdateLanguageCommandValidator()
	{
		RuleFor(x => x.Language)
			.NotEmpty().WithMessage("Pole nie może być puste!");
	}
}