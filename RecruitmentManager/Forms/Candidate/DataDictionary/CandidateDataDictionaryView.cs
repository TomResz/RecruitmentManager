using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Forms.Candidate.JobOfferViews;

namespace RecruitmentManager.Forms.Candidate.DataDictionary;

public partial class CandidateDataDictionaryView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	private UserControl _currentControl;
	public CandidateDataDictionaryView(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		InitializeComponent();
		var initForm = _serviceProvider.GetRequiredService<CandidateExperienceView>();
		ShowControl(initForm);

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
				mainLayout.Controls.Add(controlToShow, 0, 1);
			}
			controlToShow.Visible = true;
			_currentControl = controlToShow;
		}
	}
	private void experienceBtn_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<CandidateExperienceView>();
		ShowControl(uc);
	}

	private void languageKnowledgeTabBtn_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<CandidateLanguageKnowledgeView>();
		ShowControl(uc);
	}
}