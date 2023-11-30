using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Admin;
using RecruitmentManager.Forms.Manager.JobOffers;
using RecruitmentManager.Forms.Manager.Registrations;
using RecruitmentManager.Forms.Manager.StagesSetup;

namespace RecruitmentManager.Forms.Manager;

public partial class ManagerForm : Form
{
	private UserControl? _currentControl;
	private JobOffersMainView _mainView;

	private readonly IWorkerSessionContext _sessionContext;
	private readonly IServiceProvider _serviceProvider;

	public ManagerForm(
		IWorkerSessionContext sessionContext,
		IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_sessionContext = sessionContext;
		_serviceProvider = serviceProvider;
		userLabel.Text = _sessionContext.FullName;
		_mainView = _serviceProvider.GetRequiredService<JobOffersMainView>();
		ShowControl(_mainView);
	}

	private void logoutBtn_Click(object sender, EventArgs e)
	{
		var confirmation = MessageBox.Show("Czy chcesz się wylogować?", "Wyloguj się.",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.No)
			return;
		_sessionContext.Logout();
		var loginForm = _serviceProvider.GetRequiredService<LoginWorkerForm>();
		this.Hide();
		loginForm.FormClosed += (s, args) => this.Close();
		loginForm.Show();
	}

	private void edytujDaneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var editForm = _serviceProvider.GetRequiredService<EditEmployeeDataForm>();
		editForm.ShowDialog();
	}

	private void jobOffersBtn_Click(object sender, EventArgs e)
	{
		var form = _serviceProvider.GetRequiredService<JobOffersMainView>();
		ShowControl(form);
	}
	public void ShowControl(UserControl controlToShow)
	{
		if (_currentControl != controlToShow)
		{
			if (_currentControl is not null)
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

	private void registrationsBtn_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<ManagerMainRegistrationView>();
		ShowControl(uc);
	}

	private void stagesBtn_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<StagesSetupView>();
		ShowControl(uc);
	}

}