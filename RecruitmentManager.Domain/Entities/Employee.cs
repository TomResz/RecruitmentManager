namespace RecruitmentManager.Domain.Entities;

public class Employee
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; }
    public string PasswordHash { get; set; }

    public EmployeeData EmployeeData { get; set; }
    public int RoleId { get; set; }
    public Role Role { get; set; }

    public ICollection<RecruitmentStage> RecruitmentStages { get; set; }
}
