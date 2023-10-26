using Microsoft.Extensions.DependencyInjection;

namespace RecruitmentManager.Forms.Admin;

public partial class WorkersManagementView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	public WorkersManagementView(IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
	}


	private void add_Click(object sender, EventArgs e)
	{
		var form = _serviceProvider.GetRequiredService<AddWorkerForm>();
		form.ShowDialog();
	}

	private void deleteBtn_Click(object sender, EventArgs e)
	{

	}
}
