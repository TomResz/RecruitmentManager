namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetStatisticsOfJobPosting;

public record StatisticsOfJobPostingResponse
{
    public int TotalNumberOfInterview { get; init; }
    public int TotalNumberOfResignation { get; init; }
    public int TotalNumberOfQualified{ get; init; }
    public int TotalNumberOfInterviewsHeld { get; init; }
    public int TotalNumberOfApplications{ get; init; }
}
