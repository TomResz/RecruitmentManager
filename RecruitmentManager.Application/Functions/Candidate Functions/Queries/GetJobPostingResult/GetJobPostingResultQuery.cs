using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingResult;

public record GetJobPostingResultQuery() : IRequest<List<JobPostingInfoResponse>>;
