using Microsoft.Extensions.DependencyInjection;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class JobOffersMainView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	public JobOffersMainView(
		IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		InitializeComponent();
		var actual = _serviceProvider.GetRequiredService<CurrentJobOffersView>();
		actual.Dock = DockStyle.Fill;
		tabControl.TabPages[0].Controls.Add(actual);
	}

	private void tabControl_Selected(object sender, TabControlEventArgs e)
	{
		switch (tabControl.SelectedIndex)
		{
			case 0:
				var actual = _serviceProvider.GetRequiredService<CurrentJobOffersView>();
				actual.Dock = DockStyle.Fill;
				tabControl.TabPages[0].Controls.Add(actual);
				break;
			case 1:
				var outOfDate = _serviceProvider.GetRequiredService<OutdatedJobOffersView>();
				outOfDate.Dock = DockStyle.Fill;
				tabControl.TabPages[1].Controls.Add(outOfDate);
				break;
		}
	}
}