using MediatR;
using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Register;

public class RegisterEmployeeCommandHandler
	: IRequestHandler<RegisterEmployeeCommand>
{
	private readonly IPasswordHasher<Employee> _passwordHasher;
	private readonly IEmployeeRepository _employeeRepository;
	public RegisterEmployeeCommandHandler(
		IPasswordHasher<Employee> passwordHasher,
		IEmployeeRepository employeeRepository)
	{
		_passwordHasher = passwordHasher;
		_employeeRepository = employeeRepository;
	}

	public async Task Handle(RegisterEmployeeCommand request,
		CancellationToken cancellationToken)
	{
		var validation = new RegisterEmployeeCommandValidation();
		var validationResult = await validation.ValidateAsync(request, cancellationToken);
		if (!validationResult.IsValid)
		{
			throw new ArgumentException(
				 FVErrorSerializer.SerializeToString(validationResult.Errors));
		}
		var employee = await _employeeRepository.GetByEmailAsync(request.Email);
		if(employee is null)
		{
			throw new ArgumentException("Adres email jest już zajęty!");
		}
		var newEmployee = new Employee
		{
			Email = request.Email,
			Id = Guid.NewGuid(),
			RoleId = (int)request.Role
		};
		var passwordHash = _passwordHasher.HashPassword(newEmployee,request.Password);
		newEmployee.PasswordHash = passwordHash;
		await _employeeRepository.Add(newEmployee);
	}
}
