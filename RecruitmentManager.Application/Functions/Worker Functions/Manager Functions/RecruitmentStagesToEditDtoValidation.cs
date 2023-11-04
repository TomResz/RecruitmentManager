using FluentValidation;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions;

public class RecruitmentStagesToEditDtoValidation
	: AbstractValidator<RecruitmentStagesToEditDto>
{
	public RecruitmentStagesToEditDtoValidation()
	{
		RuleFor(x => x.GradeWeight)
			.Must(x => x is >= 1 and <= 5)
			.WithMessage("Nieprawidłowa waga (dopuszczalny zakres od 1 do 5)!");

		RuleFor(x => x.StageName)
			.NotEmpty().WithMessage("Pusta nazwa etapu rekrutacji!")
			.MaximumLength(50).WithMessage("Przekroczono maksymalną długość (50)!");
	}
}