using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.DI;
using RecruitmentManager.Forms;
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
		var form = ServiceProvider.GetRequiredService<LoadingForm>();
		System.Windows.Forms.Application.Run(form);
	}
}