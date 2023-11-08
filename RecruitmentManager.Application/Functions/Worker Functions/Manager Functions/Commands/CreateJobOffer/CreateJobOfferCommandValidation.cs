using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CreateJobOffer;

public class CreateJobOfferCommandValidation 
	: AbstractValidator<CreateJobOfferCommand>
{
	public CreateJobOfferCommandValidation()
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
		RuleFor(x => x.CreatedDate)
			.Must(date => date > DateTime.Now.AddMinutes(-20))
			.WithMessage("Nieprawidłowa data rozpoczęcia rekrutacji!");
		RuleFor(x => x.EndDate)
			.Must(date => date >= DateTime.Now.AddDays(1))
			.WithMessage("Nieprawidłowa data zakończenia rekrutacji!");
		RuleFor(x => x.RecruitmentStagesDtos)
			.Cascade(CascadeMode.Stop)
			.Must(i=>i.Count != 0) 
			.WithMessage("Brak etapów rekrutacji!")
			.Must(IsCorrectOrder)
			.WithMessage("Nieprawidłowa kolejność etapów rekrutacji!");
		RuleForEach(x => x.RecruitmentStagesDtos)
			.Cascade(CascadeMode.Stop)
			.SetValidator(new RecruitmentStageDtoValidation());
	}

	private bool IsCorrectOrder(
		List<RecruitmentStagesDto> list)
	{
		return Enumerable
			.Range(1, list.Count)
			.All(i => list
				.Any(obj => obj.Order == i));
	}
}