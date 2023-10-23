namespace RecruitmentManager.Domain.Entities;

public class JobApplication
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool InterviewQualified { get; set; } = false;
    public Guid JobPostingId { get; set; }
    public JobPosting JobPosting { get; set; }
    public Guid CandidateId { get; set; }
    public Candidate Candidate { get; set; }
}
