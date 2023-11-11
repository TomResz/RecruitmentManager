namespace RecruitmentManager.Application.Functions.DTOs;

public class EducationDTO
{
	public Guid Id { get; set; }
	public string SchoolName { get; set; }
	public string? Major { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime? DateOfCompletion { get; set; }

	public int LevelOfEducationId { get; set; }
}