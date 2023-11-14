using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.UpdateData;

public class UpdateCandidateDataCommandValidation
	: AbstractValidator<UpdateCandidateDataCommand>
{
	public UpdateCandidateDataCommandValidation()
	{
		RuleFor(x => x.BasicDataDto.Picture)
			.ProfilePictureMustBeValid();
		RuleFor(x => x.BasicDataDto.DateOfBirth)
			.Must(x => x.Value <= DateTime.Now.AddYears(-16).Date)
			.WithMessage("Nieprawidłowy wiek (dopuszczalny dopiero od 16 lat)!");
		RuleFor(x => x.BasicDataDto.Email)
			.Cascade(CascadeMode.Stop)
			.EmailMustBeValid();
		RuleFor(x => x.BasicDataDto.FirstName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("imię");
		RuleFor(x => x.BasicDataDto.LastName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("nazwisko");
		RuleFor(x => x.BasicDataDto.City)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("miejscowość zamieszkania");
		RuleFor(x => x.BasicDataDto.PhoneNumber)
			.Cascade(CascadeMode.Stop)
			.PhoneNumberMustBeValid();

	}
}