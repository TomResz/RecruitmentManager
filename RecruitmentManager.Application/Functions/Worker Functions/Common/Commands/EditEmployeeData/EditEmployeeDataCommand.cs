using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Commands.EditEmployeeData;

public record EditEmployeeDataCommand(
	Guid Id,
	string FirstName,
	string LastName,
	string PhoneNumber,
	DateTime BirthDate) : IRequest;
