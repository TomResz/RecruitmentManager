using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecruitmentManager.Application;
using RecruitmentManager.FileHandling;
using RecruitmentManager.Infrastructure;
using System.Configuration;

namespace RecruitmentManager.DI;

public static class DIExtension
{
	private static string connectionString = 
		ConfigurationManager.ConnectionStrings["AzureDb"].ConnectionString;

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
				services.AddTransient<IProfilePictureGetter,ProfilePictureGetter>();	
				services.AddTransient<IPictureBoxSetter,PictureBoxSetter>();
			});
	}

}
