namespace RecruitmentManager.Domain.Entities.Candidate_Elements;

public class LanguageProficiencyLevel
{
    public int Id { get; set; }
    public string Level { get; set; }
    public ICollection<KnowledgeOfLanguage> KnowledgeOfLanguages { get; set; }
}
