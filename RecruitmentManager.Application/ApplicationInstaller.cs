using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Mapper;
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
		services.AddAutoMapper(cfg =>
		{
			cfg.AddProfile(typeof(MapperProfile));
		});
		services.AddScoped<IPasswordHasher<Candidate>,PasswordHasher<Candidate>>();
		services.AddScoped<IPasswordHasher<Employee>, PasswordHasher<Employee>>();
		return services;
	}
}
