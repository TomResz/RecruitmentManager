using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Recruiter.Stages;

namespace RecruitmentManager.Forms.Recruiter.Assessment;

public partial class ThisWeekAssessmentView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateContext _candidateContext;
	private readonly IAssessmentCandidate _assessmentCandidate;
	private readonly IMediator _mediator;
	public ThisWeekAssessmentView(
		IServiceProvider serviceProvider,
		ICandidateContext candidateContext,
		IAssessmentCandidate assessmentCandidate,
		IMediator mediator)
	{
		_serviceProvider = serviceProvider;
		_candidateContext = candidateContext;
		_assessmentCandidate = assessmentCandidate;
		_mediator = mediator;
		InitializeComponent();
		ChangeSize();
		stagesDgv.SizeChanged += ((sender, args) => ChangeSize());
		stagesDgv.AssessmentCustomClickEvent(_serviceProvider, _candidateContext, _assessmentCandidate);
		this.Load += ThisWeekAssessmentView_Load;
	}

	private async void ThisWeekAssessmentView_Load(object? sender, EventArgs e) => await ReloadDgv();

	private void ChangeSize()
	{
		stagesDgv.Columns[2].Width = (int)(stagesDgv.Width * 0.23);
		stagesDgv.Columns[3].Width = (int)(stagesDgv.Width * 0.23);
		stagesDgv.Columns[4].Width = (int)(stagesDgv.Width * 0.15);
		stagesDgv.Columns[5].Width = (int)(stagesDgv.Width * 0.15);
		stagesDgv.Columns[6].Width = (int)(stagesDgv.Width * 0.12);
		stagesDgv.Columns[7].Width = (int)(stagesDgv.Width * 0.12);
		stagesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		stagesDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private async Task ReloadDgv()
	{
		var query = new GetInterviewsByInterviewPredicateQuery(InterviewPredicate.TwoDays);
		var response = await _mediator.Send(query);
		stagesDgv.FillJobStagesDgv(response);
	}
}