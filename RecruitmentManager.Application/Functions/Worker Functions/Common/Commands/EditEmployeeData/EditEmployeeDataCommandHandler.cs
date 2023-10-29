using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Commands.EditEmployeeData;

public class EditEmployeeDataCommandHandler
	: IRequestHandler<EditEmployeeDataCommand>
{
	private readonly IEmployeeRepository _repository;

	public EditEmployeeDataCommandHandler(IEmployeeRepository repository)
	{
		_repository = repository;
	}

	public async Task Handle(
		EditEmployeeDataCommand request,
		CancellationToken cancellationToken)
	{
		var validation = new EditEmployeeDataCommandValidation();
		var result = await validation.ValidateAsync(request, cancellationToken);
		if(!result.IsValid)
		{
			throw new InvalidOperationException(FVErrorSerializer.SerializeToString(
				result.Errors));
		}
		var employee = await _repository.GetById(request.Id);
        if (employee is null)
        {
			throw new ArgumentException(nameof(request.Id));
        }
		employee.EmployeeData.FirstName = request.FirstName;
		employee.EmployeeData.LastName = request.LastName;
		employee.EmployeeData.BirthDate = request.BirthDate;
		employee.EmployeeData.PhoneNumber = request.PhoneNumber;	
		await _repository.Update(employee);
	}
}
