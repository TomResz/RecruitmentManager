namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions;

public class RecruitmentStagesDto
{
	public string StageName { get; set; }
	public int Order { get; set; }
	public int GradeWeight { get; set; }
	public Guid EmployeeId { get; set; }
}