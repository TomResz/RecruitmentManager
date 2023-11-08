using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.Active;

public class GetPageOfCurrentJobOffersQueryHandler
    : IRequestHandler<GetPageOfCurrentJobOffersQuery, PagedList<JobOffersViewDto>>
{
    private readonly IMapper _mapper;
    private readonly IDbContext _context;
    public GetPageOfCurrentJobOffersQueryHandler(
        IMapper mapper,
        IDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<PagedList<JobOffersViewDto>> Handle(
        GetPageOfCurrentJobOffersQuery request,
        CancellationToken cancellationToken)
    {
	    var date = DateTime.Now;

		IQueryable<JobPosting> query = _context.Get<JobPosting>()
            .Where(x => x.EndDate >= date)
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