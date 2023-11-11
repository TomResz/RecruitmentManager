using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Add;

public class AddEducationCommandValidator
	: AbstractValidator<AddEducationCommand>
{
	public AddEducationCommandValidator()
	{
		RuleFor(x => x.SchoolName)
			.NotEmpty().WithMessage("Nieprawidłowa nazwa placówki edukacyjnej!");
		RuleFor(x => x.Major)
			.NotEmpty().WithMessage("Nieprawidłowa nazwa specjalizacji!");
		RuleFor(x => x.LevelOfEducationId)
			.InclusiveBetween(1, 3).WithMessage("Incorrect level!");
		RuleFor(x => x.Start)
			.Must(x => x <= DateTime.Now).WithMessage("Nieprawidłowa data!")
			.Must((date, x) =>
			{
				if (date.End is null)
					return true;
				return date.End >= x;
			}).WithMessage("Nieprawidłowa data!");
	}
}