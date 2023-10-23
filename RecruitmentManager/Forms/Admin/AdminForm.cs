// Ignore Spelling: Admin

using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Admin;

namespace RecruitmentManager.Forms;

public partial class AdminForm : Form
{
	private readonly IServiceProvider _serviceProvider;
	private readonly IWorkerSessionContext _workerSessionContext;


	private UserControl _currentControl;
	private WorkersManagementView _workersManagementView;

	public AdminForm(
		IServiceProvider serviceProvider, 
		IWorkerSessionContext workerSessionContext)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
		Init();
		_workerSessionContext = workerSessionContext;
	}
	private void Init()
	{
		_workersManagementView = _serviceProvider.GetRequiredService<WorkersManagementView>();
		ShowControl(_workersManagementView);
	}

	private void logoutBtn_Click(object sender, EventArgs e)
	{
		var dialogResult = MessageBox.Show(
			text: "Czy chcesz się wylogować?",
			caption: "Wylogowywanie się?",
			buttons: MessageBoxButtons.YesNo,
			icon: MessageBoxIcon.Question);

		if (dialogResult == DialogResult.Yes)
		{
			_workerSessionContext.Logout();
			this.Hide();
			var loginForm = _serviceProvider.GetRequiredService<LoginWorkerForm>();
			loginForm.FormClosed += (s, args) => this.Close();
			loginForm.Show();
		}
	}

	public void ShowControl(UserControl controlToShow)
	{
		if (_currentControl != controlToShow)
		{
			if (_currentControl != null)
				_currentControl.Visible = false;
			if (!mainLayout.Controls.Contains(controlToShow))
			{
				controlToShow.Dock = DockStyle.Fill;
				mainLayout.Controls.Add(controlToShow, 1, 0);
			}
			controlToShow.Visible = true;
			_currentControl = controlToShow;
		}
	}
}
