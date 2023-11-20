using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Recruiter.Assessment;
using RecruitmentManager.Forms.Recruiter.Stages;

namespace RecruitmentManager.Forms.Recruiter;

public partial class RecruiterMainForm : Form
{
	private UserControl _currentControl;
	private readonly IWorkerSessionContext _sessionContext;
	private readonly IServiceProvider _serviceProvider;
	public RecruiterMainForm(IWorkerSessionContext sessionContext, IServiceProvider serviceProvider)
	{
		_sessionContext = sessionContext;
		_serviceProvider = serviceProvider;
		InitializeComponent();
		var uc = _serviceProvider.GetRequiredService<StagesMainView>();
		ShowControl(uc);
		userLabel.Text = _sessionContext.FullName;
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

	private void interviewsBtn_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<StagesMainView>();
		ShowControl(uc);
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

	private void AssessmentBtn_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<AssessmentMainView>();
		ShowControl(uc);
	}
}