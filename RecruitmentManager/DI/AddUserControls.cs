using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Forms.Admin;
using System.Reflection;

namespace RecruitmentManager.DI;

public static class AddUserControls
{
	public static IServiceCollection AddUserControlsToServices(
		this IServiceCollection services)
	{
		var userControls = Assembly
			.GetExecutingAssembly()
			.GetTypes()
			.Where(x => x.IsSubclassOf(typeof(UserControl)))
			.ToList();
		foreach(var uc in userControls)
		{
			services.AddTransient(uc);
		}
		return services;
	}
}
