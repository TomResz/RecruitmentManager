namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingResult;

public record JobPostingInfoResponse
{
    public string JobName { get; init; }
    public bool IsSelected { get; init; }
}
