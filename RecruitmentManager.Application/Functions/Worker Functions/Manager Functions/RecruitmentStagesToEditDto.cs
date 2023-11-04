namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions;

public class RecruitmentStagesToEditDto
{
	public Guid Id { get; set; }
	public string StageName { get; set; }
	public int Order { get; set; }
	public int GradeWeight { get; set; }
	public Guid EmployeeId { get; set; }
}