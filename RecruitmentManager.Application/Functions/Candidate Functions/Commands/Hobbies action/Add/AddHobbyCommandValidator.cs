using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Add;

public class AddHobbyCommandValidator
	: AbstractValidator<AddHobbyCommand>
{
	public AddHobbyCommandValidator()
	{
		RuleFor(x => x.Description)
			.Cascade(CascadeMode.Stop)
			.DescriptionMustBeValid();
	}
}