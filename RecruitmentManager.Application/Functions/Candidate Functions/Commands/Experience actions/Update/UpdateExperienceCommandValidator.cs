using FluentValidation;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Update;

public class UpdateExperienceCommandValidator
	: AbstractValidator<UpdateExperienceCommand>
{
	public UpdateExperienceCommandValidator()
	{
		RuleFor(x => x.CompanyName)
			.NotEmpty().WithMessage("Nazwa firmy nie może być pusta!");
		RuleFor(x => x.Description)
			.NotEmpty().WithMessage("Opis nie może być pusty!");
		RuleFor(x => x.Title)
			.NotEmpty().WithMessage("Nazwa stanowiska nie może być pusta!");
		RuleFor(x => x.Start)
			.Must(x => x < DateTime.Now).WithMessage("Nieprawidłowa data zaczęcia!");
		RuleFor(x => x.End)
			.Must((x, date) =>
			{
				if (date is null)
					return true;
				return date >= x.Start;
			}).WithMessage("Nieprawidłowa data zakończenia!");
	}
}