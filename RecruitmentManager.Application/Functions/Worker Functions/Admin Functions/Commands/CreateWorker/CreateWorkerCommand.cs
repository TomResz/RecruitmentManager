using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.CreateWorker;

public sealed record CreateWorkerCommand(
	string Email,
	string FirstName,
	string LastName,
	string Password,
	string ConfirmedPassword,
	int RoleId) : IRequest;
