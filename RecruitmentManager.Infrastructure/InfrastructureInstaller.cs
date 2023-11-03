using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
        services.AddSingleton<ICandidateSessionContext, CandidateSessionContext>();
        services.AddSingleton<IWorkerSessionContext, WorkerSessionContext>();
        services.AddSingleton<IUserDataToEditContext,UserDataToEditContext>();
        services.ScanForDbSeeders();
        services.AddTransient<MainSeeder>();
        return services;
    }

}
