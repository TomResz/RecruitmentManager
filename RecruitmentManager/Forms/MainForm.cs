using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Forms;
using RecruitmentManager.Forms.Candidate;

namespace RecruitmentManager;

public partial class MainForm : Form
{
	private readonly IServiceProvider _serviceProvider;
	public MainForm(IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
	}

	private void candidateModeBtn_Click(object sender, EventArgs e)
	{
		var candidateForm = _serviceProvider.GetRequiredService<CandidateNotLoginForm>();
		this.Hide();
		candidateForm.Closed += (s, args) => this.Close();
		candidateForm.Show();
	}

	private void workerModeBtn_Click(object sender, EventArgs e)
	{
		var workerForm = _serviceProvider.GetRequiredService<LoginWorkerForm>();
		this.Hide();
		workerForm.Closed += (s, args) => this.Close();
		workerForm.Show();
	}
}