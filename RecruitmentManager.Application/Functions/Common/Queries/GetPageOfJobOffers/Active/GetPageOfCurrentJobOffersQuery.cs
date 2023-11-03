using MediatR;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.Active;

public record GetPageOfCurrentJobOffersQuery(
    int Page,
    int PageSize) : IRequest<PagedList<JobOffersViewDto>>;