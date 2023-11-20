using System.Windows.Forms.VisualStyles;
using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Recruiter.Stages;

public partial class PastStagesView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	private readonly IMediator _mediator;
	private readonly ICandidateContext _candidateContext;
	public PastStagesView(IServiceProvider serviceProvider, IMediator mediator, ICandidateContext candidateContext)
	{
		_serviceProvider = serviceProvider;
		_mediator = mediator;
		_candidateContext = candidateContext;
		InitializeComponent();
		stagesDgv.JobStagesChangeSize();
		stagesDgv.SizeChanged += (s, args) => stagesDgv.JobStagesChangeSize();
		stagesDgv.AttachCustomClickEvent(_serviceProvider,_candidateContext);
		this.Load += PastStagesView_Load;
	}

	private async void PastStagesView_Load(object? sender, EventArgs e) => await ReloadPage();

	private async Task ReloadPage()
	{
		var query = new GetInterviewsByInterviewPredicateQuery(InterviewPredicate.Past);
		var response = await _mediator.Send(query);
		stagesDgv.FillJobStagesDgv(response);
	}
}