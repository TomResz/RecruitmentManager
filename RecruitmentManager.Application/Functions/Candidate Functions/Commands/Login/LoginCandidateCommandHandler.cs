using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Login;

public class LoginCandidateCommandHandler
	: IRequestHandler<LoginCandidateCommand, Guid>
{
	private readonly ICandidateRepository _candidateRepository;
	private readonly IPasswordHasher<Candidate> _passwordHasher;
	private readonly IErrorSerializer _errorSerializer;
	public LoginCandidateCommandHandler(
		ICandidateRepository candidateRepository,
		IPasswordHasher<Candidate> passwordHasher,
		IErrorSerializer errorSerializer)
	{
		_candidateRepository = candidateRepository;
		_passwordHasher = passwordHasher;
		_errorSerializer = errorSerializer;
	}

	public async Task<Guid> Handle(
		LoginCandidateCommand request, 
		CancellationToken cancellationToken)
	{
		var validation = new LoginCandidateCommandValidation();
		var result = await validation.ValidateAsync(request, cancellationToken);
		if(!result.IsValid) 
		{
			throw new InvalidDataException(_errorSerializer.Serialize(result.Errors));
		}
		var user = await _candidateRepository.GetByEmailAsync(request.Email);
		if(user is null)
		{
			throw new BadRequestException("Nieprawidłowy adres email!");
		}
		var passwordVerification = _passwordHasher.VerifyHashedPassword(user: user,
			  hashedPassword: user.PasswordHash,providedPassword: request.Password);
		if(passwordVerification == PasswordVerificationResult.Failed)
		{
			throw new BadRequestException("Nieprawidłowe hasło!");
		}
		return user.Id;
	}
}
