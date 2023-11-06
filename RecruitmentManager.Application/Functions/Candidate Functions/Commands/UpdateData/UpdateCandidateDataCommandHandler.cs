using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

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
		var candidate = await _candidateRepository.GetFullData(request.DataToEditDto.Id, cancellationToken);
		if(candidate is null)
			throw new ArgumentNullException(nameof(candidate));
		candidate.ProfilePicture.Image = request.DataToEditDto.Picture;
		candidate.Email = request.DataToEditDto.Email;
		candidate.CandidateData.FirstName = request.DataToEditDto.FirstName;
		candidate.CandidateData.LastName = request.DataToEditDto.LastName;
		candidate.CandidateData.City = request.DataToEditDto.City;
		candidate.CandidateData.PhoneNumber = request.DataToEditDto.PhoneNumber;
		candidate.CandidateData.BirthDate = request.DataToEditDto.DateOfBirth;
		await _asyncRepository.Update(candidate);
	}
}