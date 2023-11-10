using MediatR;
using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.CreateWorker;

public class CreateWorkerCommandHandler
	: IRequestHandler<CreateWorkerCommand>
{
	private readonly IEmployeeRepository _employeeRepository;
	private readonly IPasswordHasher<Employee> _passwordHasher;

	public CreateWorkerCommandHandler(
		IEmployeeRepository employeeRepository, 
		IPasswordHasher<Employee> passwordHasher)
	{
		_employeeRepository = employeeRepository;
		_passwordHasher = passwordHasher;
	}

	public async Task Handle(CreateWorkerCommand request, CancellationToken cancellationToken)
	{
		var validation = new CreateWorkerCommandValidation();
		var result = validation.Validate(request);
		if (!result.IsValid)
		{
			throw new BadRequestException(FVErrorSerializer.SerializeToString(
				result.Errors));	
		}
		var employeeWithUniqueEmail = await _employeeRepository.GetByEmailAsync(request.Email);
		if(employeeWithUniqueEmail is  not null)
		{
			throw new BadRequestException("Email jest już zajęty");
		}

		var id = Guid.NewGuid();
		var newEmployee = new Employee
		{
			Id = id,
			Email = request.Email,
			RoleId = request.RoleId,
			EmployeeData = new EmployeeData()
			{ 
				EmployeeId = id,
				FirstName = request.FirstName,
				LastName = request.LastName,
			}
		};
		var passwordHah = _passwordHasher.HashPassword(newEmployee, request.Password);
		newEmployee.PasswordHash = passwordHah;
		await _employeeRepository.Add(newEmployee);	

	}
}
