namespace RecruitmentManager.Domain.Entities;

public class Hobby
{
	public Guid Id { get; set; }
	public string Description { get; set; }
	public Candidate Candidate { get; set; }
	public Guid CandidateId { get; set; }
}