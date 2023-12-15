using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetPageOfEndedJobOffers;

internal class GetPageOfEndedJobOffersQueryHandler
	: IRequestHandler<GetPageOfEndedJobOffersQuery, PagedList<JobOffersViewDto>>
{
	private readonly IDbContext _context;
	private readonly IMapper _mapper;
	public GetPageOfEndedJobOffersQueryHandler(
		IDbContext context,
		IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	public async Task<PagedList<JobOffersViewDto>> Handle(
		GetPageOfEndedJobOffersQuery request, 
		CancellationToken cancellationToken)
	{
		var date = DateTime.Now;
		IQueryable<JobPosting> query = _context.Get<JobPosting>()
			.Where(x => x.EndDate < date && x.IsCompleted)
			.OrderByDescending(x => x.CreatedDate)
			.ThenByDescending(x => x.EndDate)
			.AsNoTracking();

		var list = await PagedList<JobPosting>.CreateByQueryAsync(
			query,
			request.Page,
			request.PageSize);

		return _mapper.Map<PagedList<JobOffersViewDto>>(list);
	}
}
