namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions;

public class RecruiterDto
{
	public Guid Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string FullName => $"{FirstName} {LastName}";
	public string Email { get; set; }
}