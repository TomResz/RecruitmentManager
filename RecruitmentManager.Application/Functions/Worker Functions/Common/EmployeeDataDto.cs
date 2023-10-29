namespace RecruitmentManager.Application.Functions.Worker_Functions.Common;

public class EmployeeDataDto
{
	public Guid Id{ get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? BirthDate { get; set; }
}
