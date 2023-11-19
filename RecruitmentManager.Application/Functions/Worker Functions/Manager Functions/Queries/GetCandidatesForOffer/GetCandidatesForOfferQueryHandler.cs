using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetCandidatesForOffer;

public class GetCandidatesForOfferQueryHandler
	: IRequestHandler<GetCandidatesForOfferQuery,List<CandidateDTO>>
{
	private readonly ICandidateRepository _candidateRepository;

	public GetCandidatesForOfferQueryHandler(ICandidateRepository candidateRepository)
	{
		_candidateRepository = candidateRepository;
	}

	public async Task<List<CandidateDTO>> Handle(
		GetCandidatesForOfferQuery request, 
		CancellationToken cancellationToken)
	{
		var candidates = await _candidateRepository.GetByJobPostingId(request.JobPostingId);
		return candidates.Select(x => new CandidateDTO()
		{
			Id = x.Id,
			FirstName = x.CandidateData.FirstName,
			LastName = x.CandidateData.LastName,
			IsQualificated = x.JobApplications.Select(y=>y.InterviewQualified).FirstOrDefault()
		}).ToList();
	}
}