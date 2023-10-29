using FluentValidation;
using RecruitmentManager.Application.Regex_Patterns;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Commands.EditEmployeeData;

public class EditEmployeeDataCommandValidation
	: AbstractValidator<EditEmployeeDataCommand>
{
    public EditEmployeeDataCommandValidation()
    {
        RuleFor(x=>x.FirstName)
            .NotEmpty()
            .WithMessage("Puste imię!");
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Puste nazwisko!");
        RuleFor(x => x.PhoneNumber)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Pusty numer telefonu!")
            .Must(phone => new PhoneNumberValidation().IsValid(phone))
            .WithMessage("Nieprawidłowy numer telefonu!");
        RuleFor(x => x.BirthDate)
            .Must(birthDate => birthDate <= DateTime.Today.AddYears(-18))
            .WithMessage("Nieprawidłowy wiek użytkownika!");
            
    }
}
