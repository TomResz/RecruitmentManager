using Microsoft.Extensions.DependencyInjection;

namespace RecruitmentManager.Forms.Candidate;

public partial class CandidateNotLoginForm : Form
{
	private readonly IServiceProvider _serviceProvider;
	public CandidateNotLoginForm(IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
	}

	private void previousPagePB_Click(object sender, EventArgs e)
	{

	}

	private void nextPagePB_Click(object sender, EventArgs e)
	{

	}

	private void loginBtn_Click(object sender, EventArgs e)
	{
		this.Hide();
		var form = _serviceProvider.GetRequiredService<LoginCandidateForm>();
		form.FormClosed += (s, args) => this.Close();
		form.Show();
	}

	private void registerBtn_Click(object sender, EventArgs e)
	{
		this.Hide();
		var form = _serviceProvider.GetRequiredService<RegisterCandidateForm>();
		form.FormClosed += (s, args) => this.Close();
		form.Show();
	}
}
