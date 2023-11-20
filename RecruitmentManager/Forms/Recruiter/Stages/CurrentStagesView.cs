using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;
using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Forms.Recruiter.Stages;

public partial class CurrentStagesView : UserControl
{
	private readonly IMediator _mediator;
	private readonly ICandidateContext _candidateContext;
	private readonly IServiceProvider _serviceProvider;
	public CurrentStagesView(
		IMediator mediator,
		ICandidateContext candidateContext, 
		IServiceProvider serviceProvider)
	{
		_mediator = mediator;
		_candidateContext = candidateContext;
		_serviceProvider = serviceProvider;
		InitializeComponent();
		stagesDgv.JobStagesChangeSize();
		stagesDgv.SizeChanged += (s, args) => stagesDgv.JobStagesChangeSize();
		stagesDgv.AttachCustomClickEvent(_serviceProvider, _candidateContext);
		this.Load += CurrentStagesView_Load;
	}



	private async void CurrentStagesView_Load(object? sender, EventArgs e) => await LoadData();

	private async Task LoadData()
	{
		var query = new GetInterviewsByInterviewPredicateQuery(InterviewPredicate.Current);
		var response = await _mediator.Send(query);
		stagesDgv.FillJobStagesDgv(response);
	}

}