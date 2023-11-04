using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.UpdateJobOffer;

public class UpdateJobOfferCommandValidation
	: AbstractValidator<UpdateJobOfferCommand>
{
	public UpdateJobOfferCommandValidation()
	{
		RuleFor(x => x)
			.Must(x => x.CreatedDate < x.EndDate)
			.WithMessage("Data rozpoczęcia nie może być większa niż data zakończenia");
		RuleFor(x => x.Title)
			.Cascade(CascadeMode.Stop)
			.TitleMustBeValid();
		RuleFor(x => x.Description)
			.Cascade(CascadeMode.Stop)
			.DescriptionMustBeValid();
		RuleFor(x => x.StagesToEdit)
			.Cascade(CascadeMode.Stop)
			.Must(i => i.Count != 0)
			.WithMessage("Brak etapów rekrutacji!")
			.Must(IsCorrectOrder)
			.WithMessage("Nieprawidłowa kolejność etapów rekrutacji!");
		RuleForEach(x => x.StagesToEdit)
			.Cascade(CascadeMode.Stop)
			.SetValidator(new RecruitmentStagesToEditDtoValidation());
	}
	private bool IsCorrectOrder(
		List<RecruitmentStagesToEditDto> list)
	{
		return Enumerable
			.Range(1, list.Count)
			.All(i => list
				.Any(obj => obj.Order == i));
	}
}