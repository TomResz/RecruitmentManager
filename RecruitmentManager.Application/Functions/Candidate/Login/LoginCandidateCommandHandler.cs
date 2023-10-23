using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate.Login;

public class LoginCandidateCommandHandler
	: IRequestHandler<LoginCandidateCommand, Guid>
{
	public LoginCandidateCommandHandler()
	{
	}

	public Task<Guid> Handle(
		LoginCandidateCommand request, 
		CancellationToken cancellationToken)
	{
		return Task.FromResult(Guid.Empty);
	}
}
