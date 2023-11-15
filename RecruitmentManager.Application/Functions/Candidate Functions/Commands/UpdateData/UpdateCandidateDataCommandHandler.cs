using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.UpdateData;

public class UpdateCandidateDataCommandHandler
	: IRequestHandler<UpdateCandidateDataCommand>
{
	private readonly IAsyncRepository<Candidate> _asyncRepository;
	private readonly ICandidateRepository _candidateRepository;
	public UpdateCandidateDataCommandHandler(
		IAsyncRepository<Candidate> asyncRepository,
		ICandidateRepository candidateRepository)
	{
		_asyncRepository = asyncRepository;
		_candidateRepository = candidateRepository;
	}

	public async Task Handle(
		UpdateCandidateDataCommand request,
		CancellationToken cancellationToken)
	{
		var validate = new UpdateCandidateDataCommandValidation();
		var result = await validate.ValidateAsync(request, cancellationToken);
		if (!result.IsValid)
		{
			throw new InvalidDataException(FVErrorSerializer.SerializeToString(
				result.Errors));
		}
		var candidate = await _candidateRepository.GetFullWithPBData(request.BasicDataDto.Id, cancellationToken);
		if(candidate is null)
			throw new NotFoundException(nameof(candidate));
		candidate.ProfilePicture.Image = request.BasicDataDto.Picture;
		candidate.Email = request.BasicDataDto.Email;
		candidate.CandidateData.FirstName = request.BasicDataDto.FirstName;
		candidate.CandidateData.LastName = request.BasicDataDto.LastName;
		candidate.CandidateData.City = request.BasicDataDto.City;
		candidate.CandidateData.PhoneNumber = request.BasicDataDto.PhoneNumber;
		candidate.CandidateData.BirthDate = request.BasicDataDto.DateOfBirth;
		await _asyncRepository.Update(candidate);
	}
}