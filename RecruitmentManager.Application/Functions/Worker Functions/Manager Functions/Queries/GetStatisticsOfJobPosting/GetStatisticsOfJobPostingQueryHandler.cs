using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetStatisticsOfJobPosting;

internal class GetStatisticsOfJobPostingQueryHandler
	: IRequestHandler<GetStatisticsOfJobPostingQuery, StatisticsOfJobPostingResponse>
{
	private readonly IDbContext _dbContext;

	public GetStatisticsOfJobPostingQueryHandler(IDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<StatisticsOfJobPostingResponse> Handle(GetStatisticsOfJobPostingQuery request, CancellationToken cancellationToken)
	{
		var totalNumberOfApplications = await _dbContext
			.Get<JobApplication>()
			.Where(x => x.JobPostingId == request.JobPostingId)
			.CountAsync();

		var totalNumberOfInterview = await _dbContext
			.Get<CandidateRating>()
			.Include(x => x.RecruitmentStage)
			.Where(x => x.RecruitmentStage.JobPostingId == request.JobPostingId)
			.CountAsync();

		var totalNumberOfQualified = await _dbContext
			.Get<JobApplication>()
			.Where(x => x.JobPostingId == request.JobPostingId && x.InterviewQualified)
			.CountAsync();

		var totalNumberOfInterviewHeld = await _dbContext
			.Get<CandidateRating>()
			.Include(x => x.RecruitmentStage)
			.Where(x => x.RecruitmentStage.JobPostingId == request.JobPostingId &&
				x.Grade != null )
			.CountAsync();

		var totalNumberOfInterviewResignation = await _dbContext
			.Get<CandidateRating>()
			.Include(x => x.RecruitmentStage)
			.Where(x => x.RecruitmentStage.JobPostingId == request.JobPostingId &&
				x.Grade != null && x.HasResigned)
			.CountAsync();

		return new StatisticsOfJobPostingResponse()
		{
			TotalNumberOfInterview = totalNumberOfInterview,
			TotalNumberOfInterviewsHeld = totalNumberOfInterviewHeld,
			TotalNumberOfQualified = totalNumberOfQualified,
			TotalNumberOfApplications = totalNumberOfApplications,
			TotalNumberOfResignation = totalNumberOfInterviewResignation
		};
	}
}
