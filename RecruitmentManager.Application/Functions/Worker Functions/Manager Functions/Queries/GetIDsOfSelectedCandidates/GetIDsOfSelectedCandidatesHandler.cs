using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetIDsOfSelectedCandidates;

internal class GetIDsOfSelectedCandidatesHandler
	: IRequestHandler<GetIDsOfSelectedCandidatesQuery, List<Guid>>
{
	private readonly IDbContext _dbContext;

	public GetIDsOfSelectedCandidatesHandler(IDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<List<Guid>> Handle(GetIDsOfSelectedCandidatesQuery request, CancellationToken cancellationToken) 
		=> await _dbContext.Get<SelectedCandidatesToJob>()
			.Where(x => x.JobPostingId == request.JobPostingId)
			.Select(x => x.CandidateId)
			.ToListAsync(cancellationToken);
}
