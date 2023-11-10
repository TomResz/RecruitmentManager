using MediatR;
using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Register;

public class RegisterCandidateCommandHandler
	: IRequestHandler<RegisterCandidateCommand>
{
	private readonly ICandidateRepository _candidateRepository;
	private readonly IPasswordHasher<Candidate> _passwordHasher;

	public RegisterCandidateCommandHandler(
		ICandidateRepository candidateRepository,
		IPasswordHasher<Candidate> passwordHasher)
	{
		_candidateRepository = candidateRepository;
		_passwordHasher = passwordHasher;
	}

	public async Task Handle(
		RegisterCandidateCommand request,
		CancellationToken cancellationToken)
	{
		var validation = new RegisterCandidateValidation();
		var result = await validation.ValidateAsync(request, cancellationToken);
		if (!result.IsValid)
		{
			throw new BadRequestException(
				FVErrorSerializer.SerializeToString(result.Errors));
		}
		var user = await _candidateRepository.GetByEmailAsync(request.Email);
		if (user is not null)
		{
			throw new NotFoundException("Email jest już zajęty!");
		}

		var candidate = new Candidate
		{
			Id = Guid.NewGuid(),
			Email = request.Email,
			CandidateData = new CandidateData
			{
				FirstName = request.FirstName,
				LastName = request.LastName,
			},
			ProfilePicture = new ProfilePicture()
		};
		var passwordHash = _passwordHasher.HashPassword(candidate, request.Password);
		candidate.PasswordHash = passwordHash;
		await _candidateRepository.Add(candidate);
	}
}
