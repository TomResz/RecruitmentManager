namespace RecruitmentManager.Application.Functions.DTOs;

public class JobOffersWhereCandidateAppliedViewDto
{
	public Guid Id { get; set; }
	public string Title { get; set; }
	public bool InterviewQualified { get; set; }
	public DateTime AddedDate { get; set; }
}