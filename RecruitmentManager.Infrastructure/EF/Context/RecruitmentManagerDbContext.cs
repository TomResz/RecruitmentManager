using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Infrastructure.EF.Context;

public class RecruitmentManagerDbContext : DbContext
{
	public DbSet<CandidateData> CandidateData { get; set; }
	public DbSet<Education> Education { get; set; }
	public DbSet<Experience> Experiences { get; set; }
	public DbSet<KnowledgeOfLanguage> KnowledgeOfLanguages { get; set; }
	public DbSet<LanguageProficiencyLevel> LanguageProficiencies { get; set; }
	public DbSet<LevelOfEducation> LevelOfEducations { get; set; }
	public DbSet<Skill> Skills { get; set; }
	public DbSet<Candidate> Candidates { get; set; }
	public DbSet<Employee> Employees { get; set; }
	public DbSet<EmployeeData> EmployeeData { get; set; }
	public DbSet<Role> Roles { get; set; }
	public DbSet<JobPosting> JobPostings { get; set; }
	public DbSet<RecruitmentStage> RecruitmentStages { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }
    public DbSet<SelectedCandidatesToJob> SelectedCandidatesToJobs { get; set; }

    public RecruitmentManagerDbContext(
		DbContextOptions<RecruitmentManagerDbContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(
			  typeof(RecruitmentManagerDbContext).Assembly);
	}

}

