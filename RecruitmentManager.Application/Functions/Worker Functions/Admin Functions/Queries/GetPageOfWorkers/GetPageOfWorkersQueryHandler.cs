using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries.GetPageOfWorkers;

public class GetPageOfWorkersQueryHandler
	: IRequestHandler<GetPageOfWorkersQuery, PagedList<WorkerViewDTO>>
{
	private readonly IDbContext _context;
	private readonly IMapper _mapper;

	public GetPageOfWorkersQueryHandler(
		IDbContext context,
		IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	public async Task<PagedList<WorkerViewDTO>> Handle(
		GetPageOfWorkersQuery request,
		CancellationToken cancellationToken)
	{
		IQueryable<Employee> query = _context.Get<Employee>()
			.Include(e=>e.EmployeeData);

		var list = await PagedList<Employee>.CreateByQueryAsync(
			query: query, 
			page: request.Page, 
			pageSize: request.PageSize);

		return _mapper.Map<PagedList<WorkerViewDTO>>(list);
	}
}
