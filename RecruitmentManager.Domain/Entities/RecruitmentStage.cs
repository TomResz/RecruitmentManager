namespace RecruitmentManager.Domain.Entities;

public class RecruitmentStage
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string StageName { get; set; }
    public int Order { get; set; }
    public int GradeWeight { get; set; }

    public Guid JobPostingId { get; set; }
    public JobPosting JobPosting { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
