namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfSelectedCandidates;

public record CandidateResponse
{
    public Guid Id { get; init; }
    public string FullName { get; init; }
}
