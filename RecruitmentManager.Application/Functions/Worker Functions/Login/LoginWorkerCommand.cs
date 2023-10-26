using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Login;

public sealed record LoginWorkerCommand(
	string Email,
	string Password) : IRequest<LoginWorkerResponse>;
