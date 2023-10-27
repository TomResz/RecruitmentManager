using Microsoft.Extensions.Hosting;
using RecruitmentManager.Application;
using RecruitmentManager.Infrastructure;
using System.Configuration;
using System.Globalization;

namespace RecruitmentManager.DI;

public static class DIExtension
{
	private static string connectionString = 
		ConfigurationManager.ConnectionStrings["LocalDb"].ConnectionString;

	public static IHostBuilder CreateHostBuilder()
	{
		return Host
			.CreateDefaultBuilder()
			.ConfigureServices(services =>
			{
				services.AddLanguage();
				services.AddInfrastructure(connectionString);
				services.AddApplication();
				services.AddFormsToDI();
				services.AddUserControlsToServices();
			});
	}

}
