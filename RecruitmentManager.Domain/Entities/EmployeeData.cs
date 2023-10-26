namespace RecruitmentManager.Domain.Entities;

// one to zero or one from Employee
public class EmployeeData
{
	public Guid EmployeeId { get; set; }
	public Employee Employee { get; set; }

	public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? BirthDate { get; set; }
}
