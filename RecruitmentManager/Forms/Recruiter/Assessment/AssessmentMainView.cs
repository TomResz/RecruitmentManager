using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Recruiter.Assessment;

public partial class AssessmentMainView : UserControl
{
	private UserControl? _userControl;
	private readonly IServiceProvider _serviceProvider;
	public AssessmentMainView(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		InitializeComponent();
		mainLayout.ShowControl(_serviceProvider.GetRequiredService<ThisWeekAssessmentView>(), ref _userControl);
	}

	private void currentBtn_Click(object sender, EventArgs e)
		=> mainLayout.ShowControl(_serviceProvider.GetRequiredService<ThisWeekAssessmentView>(), ref _userControl);

}