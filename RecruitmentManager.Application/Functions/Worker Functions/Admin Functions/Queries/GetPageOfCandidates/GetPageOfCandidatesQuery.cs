using MediatR;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries.GetPageOfCandidates;

public record GetPageOfCandidatesQuery(
	int Page,
	int PageSize) : IRequest<PagedList<CandidateViewDTO>>;
