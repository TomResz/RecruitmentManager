namespace RecruitmentManager.Application.Functions.Common.Queries;

public class JobOffersViewDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime EndDate { get; set; }
}