using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetStatisticsOfJobPosting;

public record GetStatisticsOfJobPostingQuery(
	Guid JobPostingId) : IRequest<StatisticsOfJobPostingResponse>;
