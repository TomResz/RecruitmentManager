using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Recruiter.Stages;

namespace RecruitmentManager.Forms.Recruiter.Assessment;

public partial class AllAssessmentView : UserControl
{
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateContext _candidateContext;
	private readonly IAssessmentCandidate _assessmentCandidate;
	private readonly IMediator _mediator;
	public AllAssessmentView(IServiceProvider serviceProvider, ICandidateContext candidateContext, IAssessmentCandidate assessmentCandidate, IMediator mediator)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
		_candidateContext = candidateContext;
		_assessmentCandidate = assessmentCandidate;
		_mediator = mediator;
		stagesDgv.SizeChanged += (s, args) => ChangeSize();
		this.Load += AllAssessmentView_Load;
		stagesDgv.AssessmentCustomClickEvent(_serviceProvider, _candidateContext, _assessmentCandidate);
	}

	private async void AllAssessmentView_Load(object? sender, EventArgs e) => await ReloadDgv();

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
		var response = await _mediator.Send(new GetInterviewsByInterviewPredicateQuery(InterviewPredicate.All));
		stagesDgv.FillJobStagesDgv(response);
	}
}
