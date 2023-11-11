using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Edit;

public class EditHobbyCommandValidator
	: AbstractValidator<EditHobbyCommand>
{
	public EditHobbyCommandValidator()
	{
		RuleFor(x => x.Description)
			.Cascade(CascadeMode.Stop)
			.DescriptionMustBeValid();
	}
}