using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Forms.Admin;

namespace RecruitmentManager.DI;

public static class AddUserControls
{
	public static IServiceCollection AddUserControlsToServices(
		this IServiceCollection services)
	{
		services.AddTransient<WorkersManagementView>();
		return services;
	}
}
