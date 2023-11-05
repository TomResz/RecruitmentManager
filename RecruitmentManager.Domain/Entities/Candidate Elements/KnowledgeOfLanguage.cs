namespace RecruitmentManager.Domain.Entities.Candidate_Elements;

public class KnowledgeOfLanguage
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Language { get; set; }
	public int LanguageProficiencyLevelId { get; set; } 
	public LanguageProficiencyLevel LanguageProficiencyLevel { get; set; }
	public Guid CandidateId { get; set; }
	public Candidate Candidate { get; set; }
}
