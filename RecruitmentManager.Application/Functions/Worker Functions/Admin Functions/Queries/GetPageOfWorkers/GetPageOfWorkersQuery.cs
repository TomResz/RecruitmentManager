using MediatR;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries.GetPageOfWorkers;

public record GetPageOfWorkersQuery(
	int Page,
	int PageSize) : IRequest<PagedList<WorkerViewDTO>>;
