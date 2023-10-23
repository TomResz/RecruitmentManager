namespace RecruitmentManager.Domain.Entities.Candidate_Elements;

public class Education
{
    public Guid Id { get; set; } = Guid.NewGuid();
	public string SchoolName { get; set; }
    public string? Major { get; set; }
    public DateTime StartDate { get; set; }

    public bool IsCompleted { get; set; } = true;
    public DateTime? DateOfCompletion{ get; set; }

    public int LevelOfEducationId { get; set; }
    public LevelOfEducation LevelOfEducation { get; set; }
	public Guid CandidateId { get; set; }
	public Candidate Candidate { get; set; }
}
