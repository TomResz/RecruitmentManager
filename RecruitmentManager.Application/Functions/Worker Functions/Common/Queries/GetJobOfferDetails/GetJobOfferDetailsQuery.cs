using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries.GetJobOfferDetails;

public record GetJobOfferDetailsQuery(
	Guid id) : IRequest<GetJobOfferDetailsResponse>;