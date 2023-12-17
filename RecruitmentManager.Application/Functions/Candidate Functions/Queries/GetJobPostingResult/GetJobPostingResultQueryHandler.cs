using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingResult;

internal sealed class GetJobPostingResultQueryHandler
	: IRequestHandler<GetJobPostingResultQuery, List<JobPostingInfoResponse>>
{
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IDbContext _dbContext;
	public GetJobPostingResultQueryHandler(ICandidateSessionContext candidateSessionContext, IDbContext dbContext)
	{
		_candidateSessionContext = candidateSessionContext;
		_dbContext = dbContext;
	}

	public async Task<List<JobPostingInfoResponse>> Handle(GetJobPostingResultQuery request, CancellationToken cancellationToken)
	{
		var candidateId = _candidateSessionContext.CandidateId
			?? throw new BadRequestException(nameof(Guid));

		List<Guid> jobPostingIDs = await _dbContext.Get<JobApplication>()
			.Include(x => x.Candidate)
			.Include(x => x.JobPosting)
			.Where(x => x.CandidateId == candidateId &&
					x.JobPosting.IsCandidatesSelected)
			.Select(x => x.JobPostingId)
			.ToListAsync(cancellationToken);


		var selectedRows = await _dbContext.Get<SelectedCandidatesToJob>()
			.Include(sc => sc.JobPosting)
			.Where(sc => sc.JobPosting.IsCandidatesSelected &&
						 _dbContext.Get<JobApplication>()
							 .Any(ja => ja.CandidateId == candidateId &&
										ja.JobPostingId == sc.JobPostingId))
			.ToListAsync(cancellationToken);

		var responses = new List<JobPostingInfoResponse>();
		foreach (var jobPostingId in jobPostingIDs)
		{
			var actualJobOffer = await _dbContext.Get<JobPosting>()
				.AsNoTracking()
				.FirstOrDefaultAsync(x => x.Id == jobPostingId,cancellationToken);

			if (actualJobOffer is null)
				continue;

			if (selectedRows.Where(x => x.JobPostingId == jobPostingId 
				&& x.CandidateId == candidateId).Any())
			{
				responses.Add(new JobPostingInfoResponse
				{
					IsSelected = true,
					JobName = actualJobOffer.Title 
				}) ;
			}
			else
			{
				responses.Add(new JobPostingInfoResponse
				{
					IsSelected = false,
					JobName =actualJobOffer.Title	
				});
			}

		}

		return responses;

	}
}
