using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RecruitmentManager.DI;

public static class AddForms
{
	public static IServiceCollection AddFormsToDI(this IServiceCollection services)
	{
		var forms = Assembly
			.GetExecutingAssembly()
			.GetTypes()
			.Where(x=>x.IsSubclassOf(typeof(Form)))
			.ToList();
		foreach (var form in forms)
		{
			services.AddTransient(form);
		}

		return services;
	}
}
