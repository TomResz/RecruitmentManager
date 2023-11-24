namespace RecruitmentManager.Domain.Entities;

public class JobPosting
{
    public Guid Id { get; set; } = Guid.NewGuid();  
    public DateTime CreatedDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsCompleted { get; set; } = false;
    public string Title { get; set; }
    public string Description { get; set; }
    public int NumberOfPositions { get; set; }
    public ICollection<RecruitmentStage> RecruitmentStages { get; set; }
    public ICollection<JobApplication> JobApplications { get; set; }
    public ICollection<SelectedCandidatesToJob> SelectedCandidatesToJobs { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
