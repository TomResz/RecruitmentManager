using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Candidate.Interviews;

public partial class CandidateInterviewMainView : UserControl
{
	private UserControl? _userControl = new();
	private readonly IServiceProvider _serviceProvider;
	public CandidateInterviewMainView(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		InitializeComponent();
		mainLayout.ShowControl(_serviceProvider.GetRequiredService<CandidateCurrentInterviewsView>(),
			ref _userControl);
	}

	private void currentBtn_Click(object sender, EventArgs e)
		=> mainLayout.ShowControl(_serviceProvider.GetRequiredService<CandidateCurrentInterviewsView>(),
			ref _userControl);

	private void pastBtn_Click(object sender, EventArgs e)
		=> mainLayout.ShowControl(_serviceProvider.GetRequiredService<CandidatePastInterviewsView>(),
			ref _userControl);
}