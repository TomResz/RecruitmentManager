using FluentValidation;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SetDateOfInterview;

public class SetDateOfInterviewCommandValidation
	: AbstractValidator<SetDateOfInterviewCommand>
{
	public SetDateOfInterviewCommandValidation()
	{
		RuleFor(x => x.Date)
			.Must(date=>date.Hour is >= 6 and <= 22).WithMessage("Nieprawidłowa godzina!")
			.Must(date => date.DayOfWeek is not DayOfWeek.Sunday).WithMessage("W niedziele nie pracujemy!")
			.Must(date => date > DateTime.Now).WithMessage("Nie można ustawiać daty do tyłu!");
	}
}