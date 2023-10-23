using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.DI;
using RecruitmentManager.Infrastructure.EF.Seeders;

namespace RecruitmentManager;

internal static class Program
{
	public static IServiceProvider ServiceProvider { get; private set; }
	[STAThread]
	static void Main()
	{
		System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

		ApplicationConfiguration.Initialize();
		ServiceProvider =
			DIExtension
			.CreateHostBuilder()
			.Build()
			.Services;
		var db = ServiceProvider.GetRequiredService<MainSeeder>();
		db.Initialize();

		var form = ServiceProvider.GetRequiredService<MainForm>();
		System.Windows.Forms.Application.Run(form);
	}
}