using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Infrastructure.EF.Repositories;

namespace RecruitmentManager.Infrastructure;

internal static class RepositoryInstaller
{
	public static IServiceCollection AddRepositories(this IServiceCollection services)
	{
		services.AddScoped<ICandidateRepository, CandidateRepository>();
		services.AddScoped<IEmployeeRepository, EmployeeRepository>();
		services.AddScoped<IJobPostingRepository, JobPostingRepository>();
		services.AddScoped<IRecruitmentStageRepository, RecruitmentStageRepository>();
		services.AddScoped<IJobApplicationRepository, JobApplicationRepository>();
		services.AddScoped<IKnowledgeOfLanguageRepository, KnowledgeOfLanguageRepository>();
		services.AddScoped<IHobbyRepository, HobbyRepository>();
		services.AddScoped<IEducationRepository, EducationRepository>();
		services.AddScoped<IExperienceRepository, ExperienceRepository>();
		services.AddScoped<ISkillRepository, SkillRepository>();
		services.AddScoped<ICandidateRatingRepository, CandidateRatingRepository>();
		return services;
	}
}