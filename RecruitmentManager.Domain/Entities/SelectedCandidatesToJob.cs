namespace RecruitmentManager.Domain.Entities;

public class SelectedCandidatesToJob
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CandidateId { get; set; }
    public Candidate Candidate { get; set; }
    public Guid JobPostingId { get; set; }
    public JobPosting JobPosting { get; set; }
}
