using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Login;

public sealed record LoginWorkerResponse(
	Guid Id,
	string FullName,
	Roles Role);
