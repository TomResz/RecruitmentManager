using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateDataToEdit;

public class GetCandidateDataToEditQueryHandler
	: IRequestHandler<GetCandidateDataToEditQuery,CandidateBasicDataDTO>
{
	private readonly ICandidateRepository _candidateRepository;

	public GetCandidateDataToEditQueryHandler(
		ICandidateRepository candidateRepository)
	{
		_candidateRepository = candidateRepository;
	}

	public async Task<CandidateBasicDataDTO> Handle(
		GetCandidateDataToEditQuery request,
		CancellationToken cancellationToken)
	{
		var candidate = await _candidateRepository.GetFullData(request.CandidateId, cancellationToken);
		if(candidate is null)
			throw new NotFoundException(nameof(candidate));
		return new CandidateBasicDataDTO(
			id: candidate.Id,
			firstName: candidate.CandidateData.FirstName,
			lastName: candidate.CandidateData.LastName, 
			picture: candidate.ProfilePicture.Image,
			phoneNumber: candidate.CandidateData.PhoneNumber, 
			email: candidate.Email,
			city: candidate.CandidateData.City, 
			dateOfBirth: candidate.CandidateData.BirthDate);
	}
}