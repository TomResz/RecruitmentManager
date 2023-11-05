using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Domain.Entities;

public class Candidate
{
	public Guid Id { get; set; }
	public string Email { get; set; }
	public string PasswordHash { get; set; }
	public CandidateData CandidateData { get; set; }
	public ProfilePicture ProfilePicture { get; set; }
	public ICollection<Experience> Experiences { get; set; }
	public ICollection<KnowledgeOfLanguage> KnowledgeOfLanguages { get; set; }
	public ICollection<Skill> Skills { get; set; }
    public ICollection<JobApplication> JobApplications { get; set; }
    public ICollection<SelectedCandidatesToJob> SelectedCandidatesToJobs { get; set; }
}
