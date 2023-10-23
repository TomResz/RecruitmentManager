namespace RecruitmentManager.Domain.Entities.Candidate_Elements;

public class LevelOfEducation
{
	public int Id { get; set; }
	public string Name { get; set; }
	public ICollection<Education> Educations { get; set; }
}
