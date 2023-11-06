using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.UpdateData;

public class UpdateCandidateDataCommandValidation
	: AbstractValidator<UpdateCandidateDataCommand>
{
	public UpdateCandidateDataCommandValidation()
	{
		RuleFor(x => x.DataToEditDto.Picture)
			.ProfilePictureMustBeValid();
		RuleFor(x => x.DataToEditDto.DateOfBirth)
			.Must(x => x.Value <= DateTime.Now.AddYears(-16).Date)
			.WithMessage("Nieprawidłowy wiek (dopuszczalny dopiero od 16 lat)!");
		RuleFor(x => x.DataToEditDto.Email)
			.Cascade(CascadeMode.Stop)
			.EmailMustBeValid();
		RuleFor(x => x.DataToEditDto.FirstName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("imię");
		RuleFor(x => x.DataToEditDto.LastName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("nazwisko");
		RuleFor(x => x.DataToEditDto.City)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("miejscowość zamieszkania");
		RuleFor(x => x.DataToEditDto.PhoneNumber)
			.Cascade(CascadeMode.Stop)
			.PhoneNumberMustBeValid();

	}
}