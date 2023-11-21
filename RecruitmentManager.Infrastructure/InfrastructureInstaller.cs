using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Infrastructure.EF.Context;
using RecruitmentManager.Infrastructure.EF.Repositories;
using RecruitmentManager.Infrastructure.EF.Seeders;
using RecruitmentManager.Infrastructure.Services.Candidate;
using RecruitmentManager.Infrastructure.Services.Common;

namespace RecruitmentManager.Infrastructure;

public static class InfrastructureInstaller
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,string connectionString)
    {

		services.AddDbContext<RecruitmentManagerDbContext>(options =>
        {
			options.UseSqlServer(connectionString);
		});
        services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
        services.AddScoped<IDbContext, RecruitmentManagerDbContext>();
        services.AddScoped<ICandidateRepository,CandidateRepository>(); 
        services.AddScoped<IEmployeeRepository,EmployeeRepository>();
        services.AddScoped<IJobPostingRepository,JobPostingRepository>();
        services.AddScoped<IRecruitmentStageRepository,RecruitmentStageRepository>();
        services.AddScoped<IJobApplicationRepository, JobApplicationRepository>();
        services.AddScoped<IKnowledgeOfLanguageRepository,KnowledgeOfLanguageRepository>();
        services.AddScoped<IHobbyRepository,HobbyRepository>();
        services.AddScoped<IEducationRepository, EducationRepository>();
        services.AddScoped<IExperienceRepository,ExperienceRepository>();
        services.AddScoped<ISkillRepository,SkillRepository>();
        services.AddScoped<ICandidateRatingRepository,CandidateRatingRepository>();
		services.AddSingleton<ICandidateSessionContext, CandidateSessionContext>();
        services.AddSingleton<IWorkerSessionContext, WorkerSessionContext>();
        services.AddSingleton<IUserBasicDataContext,UserBasicDataContext>();
        services.AddSingleton<IJobOfferContext, JobOfferContext>();
        services.AddSingleton<ICandidateContext, CandidateContext>();
        services.ScanForDbSeeders();
        services.AddTransient<MainSeeder>();
        services.AddScoped<IErrorSerializer, ErrorSerializer>();
        return services;
    }

}
