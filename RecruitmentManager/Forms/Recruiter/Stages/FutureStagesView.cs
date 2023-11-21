using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;
using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Forms.Recruiter.Stages;

public partial class FutureStagesView : UserControl
{
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateContext _candidateContext;
	public FutureStagesView(IMediator mediator, IServiceProvider serviceProvider, ICandidateContext candidateContext)
	{
		_mediator = mediator;
		_serviceProvider = serviceProvider;
		_candidateContext = candidateContext;
		InitializeComponent();
		stagesDgv.StagesCustomClickEvent(_serviceProvider,_candidateContext);
		stagesDgv.SizeChanged += (s, args) => stagesDgv.JobStagesChangeSize();
		this.Load += CurrentStagesView_Load;
	}
	private async void CurrentStagesView_Load(object? sender, EventArgs e) => await LoadData();

	private async Task LoadData()
	{
		var query = new GetInterviewsByInterviewPredicateQuery(InterviewPredicate.Future);
		var response = await _mediator.Send(query);
		stagesDgv.FillJobStagesDgv(response);
	}


}