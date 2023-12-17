using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetPageOfCompletedJobOffers;

internal sealed class GetPageOfCompletedJobOffersQueryHandler
	: IRequestHandler<GetPageOfCompletedJobOffersQuery,PagedList<JobOffersViewDto>>
{
	private readonly IDbContext _context;
	private readonly IMapper _mapper;
	public GetPageOfCompletedJobOffersQueryHandler(IDbContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	public async Task<PagedList<JobOffersViewDto>> Handle(GetPageOfCompletedJobOffersQuery request, CancellationToken cancellationToken)
	{
		IQueryable<JobPosting> query = _context.Get<JobPosting>()
			.Where(x=>x.IsCandidatesSelected)
			.OrderByDescending(x => x.CreatedDate)
			.ThenByDescending(x => x.EndDate)
			.AsNoTracking();

		var pagedList =  await PagedList<JobPosting>
			.CreateByQueryAsync(query,
			   request.Page,
				request.PageSize);
		return _mapper.Map<PagedList<JobOffersViewDto>>(pagedList);
	}
}
