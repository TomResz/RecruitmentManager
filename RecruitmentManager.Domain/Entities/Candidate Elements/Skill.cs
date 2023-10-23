namespace RecruitmentManager.Domain.Entities.Candidate_Elements;

public class Skill
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Description { get; set; }
	public Guid CandidateId { get; set; }
	public Candidate Candidate { get; set; }
}
