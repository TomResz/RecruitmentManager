using MediatR;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetPageOfJobOffers;

public record GetPageOfJobOffersQuery(
	int Page,
	int PageSize) : IRequest<PagedList<JobOffersViewDto>>;