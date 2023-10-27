namespace RecruitmentManager.Domain.Entities;

public class CandidateData
{
	public Guid CandidateId { get; set; }
	public Candidate Candidate { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string? City { get; set; }
	public DateTime? BirthDate { get; set; }
	public string? PhoneNumber { get; set; }
}
