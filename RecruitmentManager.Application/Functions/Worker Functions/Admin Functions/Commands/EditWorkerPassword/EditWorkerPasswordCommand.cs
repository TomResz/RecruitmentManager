using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.EditWorkerPassword;

public record EditWorkerPasswordCommand(
	Guid Id, 
	string Password,
	string ConfirmedPassword) : IRequest;
