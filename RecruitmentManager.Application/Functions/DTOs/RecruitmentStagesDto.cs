namespace RecruitmentManager.Application.Functions.DTOs;

public class RecruitmentStagesDto
{
    public string StageName { get; set; }
    public int Order { get; set; }
    public int GradeWeight { get; set; }
    public Guid EmployeeId { get; set; }
}