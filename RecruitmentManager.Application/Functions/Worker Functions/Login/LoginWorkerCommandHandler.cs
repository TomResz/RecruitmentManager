using MediatR;
using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Enums;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Login;

public class LoginWorkerCommandHandler
	: IRequestHandler<LoginWorkerCommand, LoginWorkerResponse>
{
	private readonly IEmployeeRepository _repository;
	private readonly IPasswordHasher<Employee> _passwordHasher;
	private readonly IErrorSerializer _errorSerializer;
	public LoginWorkerCommandHandler(
		IEmployeeRepository repository,
		IPasswordHasher<Employee> passwordHasher, 
		IErrorSerializer errorSerializer)
	{
		_repository = repository;
		_passwordHasher = passwordHasher;
		_errorSerializer = errorSerializer;
	}

	public async Task<LoginWorkerResponse> Handle(
		LoginWorkerCommand request, 
		CancellationToken cancellationToken)
	{
		var validation = new LoginWorkerCommandValidation();
		var result  = await validation.ValidateAsync(request, cancellationToken);
		if(!result.IsValid)
		{
			throw new BadRequestException(_errorSerializer.Serialize(result.Errors));
		}
		var employee = await _repository.GetByEmailAsync(request.Email);
		if( employee is null)
		{
			throw new BadRequestException("Nieprawidłowy adres email!");
		}
		var passwordValidation = _passwordHasher.
			VerifyHashedPassword(employee, employee.PasswordHash, request.Password);
		if(passwordValidation == PasswordVerificationResult.Failed)
		{
			throw new BadRequestException("Nieprawidłowe hasło!");
		}
		return new LoginWorkerResponse(employee.Id, 
			 string.Join(" ",employee.EmployeeData.FirstName,employee.EmployeeData.LastName)
			 ,(Roles)employee.RoleId);
	}
}
