namespace RecruitmentManager.Domain.Entities;

public class Experience
{
	public Guid Id { get; set; } 
	public string JobName { get; set; }
	public string CompanyName { get; set; }
	public string? Description { get; set; }

	public DateTime StartDateOfWork { get; set; }
	public DateTime? OfCompletionOfWork { get; set; }
	public Candidate Candidate { get; set; }
	public Guid CandidateId { get; set; }
}
