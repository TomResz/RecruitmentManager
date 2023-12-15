namespace RecruitmentManager.Application.Functions.DTOs;

public class EvaluatedCandidateDto
{

    public Guid CandidateId { get; set; }
    public string FullName { get; set; }
    public double AverageGrade { get; set; }
    public int Position{ get; set; }
}
