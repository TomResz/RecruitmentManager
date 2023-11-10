using Microsoft.Extensions.DependencyInjection;

namespace RecruitmentManager.Forms.Candidate.JobOfferViews;

public partial class CandidateJobOfferMainView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	private UserControl _currentControl;


	public CandidateJobOfferMainView(
		IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		InitializeComponent();
		var initForm = _serviceProvider.GetRequiredService<CandidatePossibleJobOffersView>();
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
	private void activeJobOffersBtn_Click(object sender, EventArgs e)
	{
		var form = _serviceProvider.GetRequiredService<CandidatePossibleJobOffersView>();
		ShowControl(form);
	}

	private void myApplicationsBtn_Click(object sender, EventArgs e)
	{
		var form = _serviceProvider.GetRequiredService<CandidateApplicationsJobOffersView>();
		ShowControl(form);
	}
}