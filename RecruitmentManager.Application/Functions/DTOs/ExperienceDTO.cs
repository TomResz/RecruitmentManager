namespace RecruitmentManager.Application.Functions.DTOs;

public class ExperienceDTO
{
	public Guid Id { get; set; }
	public string JobName { get; set; }
	public string CompanyName { get; set; }
	public string? Description { get; set; }

	public DateTime StartDateOfWork { get; set; }
	public DateTime? OfCompletionOfWork { get; set; }
}