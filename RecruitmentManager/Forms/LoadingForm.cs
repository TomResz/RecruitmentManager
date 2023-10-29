using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Infrastructure.EF.Seeders;

namespace RecruitmentManager.Forms;

public partial class LoadingForm : Form
{
	private readonly IServiceProvider _serviceProvider;
	public LoadingForm(IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
		this.Load += LoadFormAsync;
	}

	private async void LoadFormAsync(object? sender, EventArgs e)
	{
		var db = _serviceProvider.GetRequiredService<MainSeeder>();
		await db.Initialize();
		await Task.WhenAll(Task.Delay(1200));
		OpenMainForm();
	}

	private void OpenMainForm()
	{
		var mainForm = _serviceProvider.GetRequiredService<MainForm>();
		this.Hide();
		mainForm.FormClosed += (s, args) => this.Close();
		mainForm.Show();
	}
}
