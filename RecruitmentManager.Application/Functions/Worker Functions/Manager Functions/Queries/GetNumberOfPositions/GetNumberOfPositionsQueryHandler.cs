using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetNumberOfPositions;

internal class GetNumberOfPositionsQueryHandler
	: IRequestHandler<GetNumberOfPositionsQuery, int>
{
	private readonly IDbContext _dbContext;

	public GetNumberOfPositionsQueryHandler(IDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<int> Handle(GetNumberOfPositionsQuery request, CancellationToken cancellationToken) 
		=> await _dbContext.Get<JobPosting>()
			.Where(x => x.Id == request.JobPostingId)
			.Select(x => x.NumberOfPositions)
			.FirstOrDefaultAsync();
}
