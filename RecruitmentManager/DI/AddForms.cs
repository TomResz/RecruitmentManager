using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Forms;
using RecruitmentManager.Forms.Candidate;

namespace RecruitmentManager.DI;

public static class AddForms
{
	public static IServiceCollection AddFormsToDI(this IServiceCollection services)
	{
		services.AddTransient<CandidateNotLoginForm>();
		services.AddTransient<RegisterCandidateForm>();
		services.AddTransient<LoginCandidateForm>();
		services.AddTransient<MainForm>();
		services.AddTransient<LoginWorkerForm>();
		services.AddTransient<AdminForm>();
		return services;
	}
}
