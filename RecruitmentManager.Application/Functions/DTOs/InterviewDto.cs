namespace RecruitmentManager.Application.Functions.DTOs;

public class InterviewDto
{
	public Guid Id { get; set; }
	public string CandidateFullName { get; set; }
	public string StageName { get; set; }
	public string JobTitle { get; set; }
	public DateTime? Date { get; set; }
	public bool HasResigned { get; set; } = false;
}