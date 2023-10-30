using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Commands.EditEmployeeData;

public class EditEmployeeDataCommandValidation
	: AbstractValidator<EditEmployeeDataCommand>
{
	public EditEmployeeDataCommandValidation()
	{
		RuleFor(x => x.FirstName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("imię");
		RuleFor(x => x.LastName)
			.Cascade(CascadeMode.Stop)
			.NameMustBeValid("nazwisko");

		RuleFor(x => x.PhoneNumber)
			.Cascade(CascadeMode.Stop)
			.PhoneNumberMustBeValid();
		RuleFor(x => x.BirthDate)
			.Must(birthDate => birthDate <= DateTime.Today.AddYears(-18).AddDays(1))
			.WithMessage("Nieprawidłowy wiek użytkownika!");

	}
}
