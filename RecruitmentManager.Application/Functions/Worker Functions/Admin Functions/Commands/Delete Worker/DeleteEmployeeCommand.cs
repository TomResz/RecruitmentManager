using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.Delete_Worker;

public record DeleteEmployeeCommand(Guid Id) : IRequest;
