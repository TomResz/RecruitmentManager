namespace RecruitmentManager.Domain.Entities.Candidate_Elements;

public class ProfilePicture
{
	public Guid CandidateId { get; set; }
	public Candidate Candidate { get; set; }
	public byte[]? Image { get; set; }
}