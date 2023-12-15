using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetPageOfEndedJobOffers;

public record GetPageOfEndedJobOffersQuery(
	int Page,
	int PageSize) : IRequest<PagedList<JobOffersViewDto>>;

