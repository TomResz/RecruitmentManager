using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries.GetJobOfferDetails;

public class GetJobOfferDetailsQueryHandler
	: IRequestHandler<GetJobOfferDetailsQuery, GetJobOfferDetailsResponse>
{
	private readonly IAsyncRepository<JobPosting> _jobPostingRepository;

	public GetJobOfferDetailsQueryHandler(
		IAsyncRepository<JobPosting> jobPostingRepository)
	{
		_jobPostingRepository = jobPostingRepository;
	}

	public async Task<GetJobOfferDetailsResponse> Handle(
		GetJobOfferDetailsQuery request,
		CancellationToken cancellationToken)
	{
		var offer = await _jobPostingRepository.GetById(request.id);
		if (offer is null)
		{
			throw new ArgumentException("Błąd przy wczytywanie oferty!");
		}
		return new(
			offer.Title,
			offer.Description,
			offer.CreatedDate,
			offer.EndDate,
			offer.NumberOfPositions);
	}
}