using MediatR;
using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.EditWorkerPassword;

public class EditWorkerPasswordCommandHandler
	: IRequestHandler<EditWorkerPasswordCommand>
{
	private readonly IEmployeeRepository _employeeRepository;
	private readonly IPasswordHasher<Employee> _passwordHasher;
	public EditWorkerPasswordCommandHandler(
		IEmployeeRepository employeeRepository,
		IPasswordHasher<Employee> passwordHasher)
	{
		_employeeRepository = employeeRepository;
		_passwordHasher = passwordHasher;
	}

	public async Task Handle(
		EditWorkerPasswordCommand request,
		CancellationToken cancellationToken)
	{
		var validate = new EditWorkerPasswordCommandValidation();
		var resultOfValidation = validate.Validate(request);
		if(!resultOfValidation.IsValid)
		{
			throw new ArgumentException(
				 FVErrorSerializer.SerializeToString(resultOfValidation.Errors));
		}
		var worker = await _employeeRepository.GetById(request.Id);
		if (worker is null) 
		{
			throw new ArgumentException("Error 404");
		}
		var passwordHash = _passwordHasher.HashPassword(worker, request.Password);	
		worker.PasswordHash = passwordHash;
		await _employeeRepository.Update(worker);
	}
}
