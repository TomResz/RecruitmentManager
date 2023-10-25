using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Domain.Entities;
using System.Reflection;

namespace RecruitmentManager.Application;

public static class ApplicationInstaller
{
	public static IServiceCollection AddApplication(
		this IServiceCollection services)
	{
		services.AddMediatR(cfg =>
			cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		services.AddScoped<IPasswordHasher<Candidate>,PasswordHasher<Candidate>>();
		return services;
	}
}
