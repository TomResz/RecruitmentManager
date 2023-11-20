namespace RecruitmentManager.Domain.Entities;

public class CandidateRating
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public DateTime? InterviewDate { get; set; }
	public int? Grade { get; set; }
	public string? Notes { get; set; }
	public bool? HasResigned { get; set; } = false;
	public Guid RecruitmentStageId { get; set; }
	public RecruitmentStage RecruitmentStage { get; set; }
	public Guid CandidateId { get; set; }
	public Candidate Candidate { get; set; }
}
