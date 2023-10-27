using FluentValidation;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.EditWorkerPassword;

public class EditWorkerPasswordCommandValidation : 
	AbstractValidator<EditWorkerPasswordCommand>
{
    public EditWorkerPasswordCommandValidation()
    {
        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Puste hasło!")
            .MinimumLength(8)
            .WithMessage("Nieprawidłowa długość hasła!")
            .Equal(x => x.ConfirmedPassword)
            .WithMessage("Hasła się nie zgadzają!");
    }
}
