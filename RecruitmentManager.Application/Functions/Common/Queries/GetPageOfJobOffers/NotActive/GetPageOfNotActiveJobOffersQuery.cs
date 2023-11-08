using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.NotActive;

public record GetPageOfNotActiveJobOffersQuery(
	int Page,
	int PageSize) : IRequest<PagedList<JobOffersViewDto>>;