using MediatR;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Register;

public sealed record RegisterEmployeeCommand(
	string Email,
	string Password,
	Roles Role) : IRequest;
