using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetJobOfferDetailsToEdit;

public record GetJobOfferDetailsToEditQuery(
	Guid id) : IRequest<JobOfferDetailsToEditDto>;