using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfSelectedCandidates;

internal sealed class GetListOfSelectedCandidatesQueryHandler
	: IRequestHandler<GetListOfSelectedCandidatesQuery, List<CandidateResponse>>
{
	private readonly IDbContext _context;

	public GetListOfSelectedCandidatesQueryHandler(IDbContext context)
	{
		_context = context;
	}

	public async Task<List<CandidateResponse>> Handle(GetListOfSelectedCandidatesQuery request, CancellationToken cancellationToken) 
		=> await _context.Get<Candidate>()
			.Include(x => x.CandidateData)
			.Include(x => x.SelectedCandidatesToJobs)
			.Where(x => x.SelectedCandidatesToJobs.Any(y => y.JobPostingId == request.JobPostingId))
			.Select(x => new CandidateResponse()
			{
				Id = x.Id,
				FullName = $"{x.CandidateData.FirstName} {x.CandidateData.LastName}"
			})
			.ToListAsync(cancellationToken);
}
