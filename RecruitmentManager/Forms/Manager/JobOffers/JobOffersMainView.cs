using Microsoft.Extensions.DependencyInjection;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class JobOffersMainView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	private UserControl _currentControl;

	public JobOffersMainView(
		IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		InitializeComponent();
		ShowControl(_serviceProvider.GetRequiredService<CurrentJobOffersView>());
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

	private void activeBtn_Click(object sender, EventArgs e)
		=> ShowControl(_serviceProvider.GetRequiredService<CurrentJobOffersView>());

	private void completedBtn_Click(object sender, EventArgs e)
	{

	}

	private void button1_Click(object sender, EventArgs e)
				=> ShowControl(_serviceProvider.GetRequiredService<OutdatedJobOffersView>());

}