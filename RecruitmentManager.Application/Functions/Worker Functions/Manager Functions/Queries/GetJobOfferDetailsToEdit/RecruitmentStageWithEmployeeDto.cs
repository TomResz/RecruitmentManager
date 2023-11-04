namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetJobOfferDetailsToEdit;

public class RecruitmentStageWithEmployeeDto
{
	public Guid Id { get; set; }
	public Guid EmployeeId { get; set; }
	public string FullName { get; set; }
	public string StageName { get; set; }
	public int Order { get; set; }
	public int GradeWeight { get; set; }
}