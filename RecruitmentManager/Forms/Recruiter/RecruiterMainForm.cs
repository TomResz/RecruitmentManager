using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Forms.Recruiter;

public partial class RecruiterMainForm : Form
{
	private readonly IWorkerSessionContext _sessionContext;
	private readonly IServiceProvider _serviceProvider;
	public RecruiterMainForm(IWorkerSessionContext sessionContext, IServiceProvider serviceProvider)
	{
		_sessionContext = sessionContext;
		_serviceProvider = serviceProvider;
		InitializeComponent();
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

	}
}