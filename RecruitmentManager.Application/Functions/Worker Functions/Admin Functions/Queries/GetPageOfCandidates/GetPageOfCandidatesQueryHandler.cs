using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries.GetPageOfCandidates;

public class GetPageOfCandidatesQueryHandler
	: IRequestHandler<GetPageOfCandidatesQuery, PagedList<CandidateViewDTO>>
{
	private readonly IDbContext _context;
	private readonly IMapper _mapper;

	public GetPageOfCandidatesQueryHandler(
		IDbContext context,
		IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	public async Task<PagedList<CandidateViewDTO>> Handle(
		GetPageOfCandidatesQuery request,
		CancellationToken cancellationToken)
	{
		IQueryable<Candidate> query = _context.Get<Candidate>()
			.Include(e => e.CandidateData);

		var pagedList = await PagedList<Candidate>.CreateByQueryAsync(
			query: query,
			page: request.Page,
			pageSize: request.PageSize);

		return _mapper.Map<PagedList<CandidateViewDTO>>(pagedList);
	}
}
