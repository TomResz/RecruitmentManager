using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.Registrations;

public partial class ManagerMainRegistrationView : UserControl
{
	private UserControl? _currentControl;
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	public ManagerMainRegistrationView(IMediator mediator, IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_mediator = mediator;
		_serviceProvider = serviceProvider;
		mainLayout.ShowControl(_serviceProvider.GetRequiredService<ManagerCurrentsRegistrationsView>(), ref _currentControl);

	}

	private void currentBtn_Click(object sender, EventArgs e) => mainLayout.ShowControl(
			_serviceProvider.GetRequiredService<ManagerCurrentsRegistrationsView>(), ref _currentControl);

	private void endedBtn_Click(object sender, EventArgs e)
	{

	}
}
