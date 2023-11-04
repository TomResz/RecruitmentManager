using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries;

public record GetEmployeeDataQuery(
	Guid Id) : IRequest<EmployeeDataDto>;
