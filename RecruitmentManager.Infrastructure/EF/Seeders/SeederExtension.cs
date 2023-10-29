using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Infrastructure.EF.Seeders.Interface;
using System.Reflection;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public static class SeederExtension
{
	public static IServiceCollection ScanForDbSeeders(this IServiceCollection services)
	{
		var implementingTypes = Assembly
			.GetExecutingAssembly()
			.GetTypes()
			.Where(t => typeof(IAsyncDbSeeder).IsAssignableFrom(t)
				&& !t.IsInterface
				&& !t.IsAbstract)
			.ToList();

		foreach (var implementingType in implementingTypes)
		{
			services.AddTransient(typeof(IAsyncDbSeeder), implementingType);
		}
		return services;
	}
}
