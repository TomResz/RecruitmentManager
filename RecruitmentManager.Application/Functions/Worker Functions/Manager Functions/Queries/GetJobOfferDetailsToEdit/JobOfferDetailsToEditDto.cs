namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetJobOfferDetailsToEdit;

public class JobOfferDetailsToEditDto
{
	public Guid Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime CreatedDate { get; set; }
	public DateTime EndDate { get; set; }
	public int NumberOfPositions { get; set; }
	public List<RecruitmentStageWithEmployeeDto> RecruitmentStagesDtos { get; set; }
}