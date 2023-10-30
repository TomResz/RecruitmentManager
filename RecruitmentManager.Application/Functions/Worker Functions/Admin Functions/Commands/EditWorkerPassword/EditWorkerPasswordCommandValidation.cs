using FluentValidation;
using RecruitmentManager.Application.Fluent_Validation_Extension;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.EditWorkerPassword;

public class EditWorkerPasswordCommandValidation : 
	AbstractValidator<EditWorkerPasswordCommand>
{
    public EditWorkerPasswordCommandValidation()
    {
        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .PasswordMustBeValid()
            .Equal(x => x.ConfirmedPassword)
            .WithMessage("Hasła się nie zgadzają!");
    }
}
