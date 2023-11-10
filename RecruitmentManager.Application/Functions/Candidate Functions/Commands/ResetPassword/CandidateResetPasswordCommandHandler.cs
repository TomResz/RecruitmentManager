using MediatR;
using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ResetPassword.ResetPassword;

public class CandidateResetPasswordCommandHandler
	: IRequestHandler<CandidateResetPasswordCommand>
{
	private readonly ICandidateRepository _repository;
	private readonly IPasswordHasher<Candidate> _passwordHasher;
	public CandidateResetPasswordCommandHandler(
		ICandidateRepository repository,
		IPasswordHasher<Candidate> passwordHasher)
	{
		_repository = repository;
		_passwordHasher = passwordHasher;
	}

	public async Task Handle(
		CandidateResetPasswordCommand request, 
		CancellationToken cancellationToken)
	{
		var validation = new CandidateResetPasswordCommandValidation();
		var resultOfValidation = validation.Validate(request);	
		if(!resultOfValidation.IsValid)
		{
			throw new BadRequestException(FVErrorSerializer
				.SerializeToString(resultOfValidation.Errors));
		}
		var candidate = await _repository.GetById(request.CandidateId) 
			?? throw new NotFoundException("ERROR 404");

		candidate.PasswordHash = _passwordHasher.HashPassword(candidate, request.Password);
		await _repository.Update(candidate);
    }
}