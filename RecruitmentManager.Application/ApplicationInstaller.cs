using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RecruitmentManager.Application;

public static class ApplicationInstaller
{
	public static IServiceCollection AddApplication(
		this IServiceCollection services)
	{
		services.AddMediatR(cfg =>
			cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		return services;
	}
}
