using FluentValidation;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Login;

public class LoginWorkerCommandValidation 
	: AbstractValidator<LoginWorkerCommand>
{
    public LoginWorkerCommandValidation()
    {
        
    }
}
