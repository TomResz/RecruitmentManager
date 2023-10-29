using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Infrastructure.EF.Context;
using RecruitmentManager.Infrastructure.EF.Seeders.Interface;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public class MainSeeder
{
	private readonly IServiceProvider _serviceProvider;

	public MainSeeder(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}

	public async Task Initialize()
	{
		var services = _serviceProvider.GetServices<IAsyncDbSeeder>();
		foreach(var service in services)
		{
			await service.Seed();
		}
	}
}
