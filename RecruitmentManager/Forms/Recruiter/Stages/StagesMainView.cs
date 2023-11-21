using Microsoft.Extensions.DependencyInjection;

namespace RecruitmentManager.Forms.Recruiter.Stages;

public partial class StagesMainView : UserControl
{
	private UserControl _currentControl;
	private readonly IServiceProvider _serviceProvider;
	public StagesMainView(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		InitializeComponent();
		var uc = _serviceProvider.GetRequiredService<CurrentStagesView>();
		ShowControl(uc);
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
	private void currentBtn_Click(object sender, EventArgs e) => ShowControl(_serviceProvider.GetRequiredService<CurrentStagesView>());

	private void futureBtn_Click(object sender, EventArgs e) => ShowControl(_serviceProvider.GetRequiredService<FutureStagesView>());

	private void pastBtn_Click(object sender, EventArgs e) => ShowControl(_serviceProvider.GetRequiredService<PastStagesView>());
}