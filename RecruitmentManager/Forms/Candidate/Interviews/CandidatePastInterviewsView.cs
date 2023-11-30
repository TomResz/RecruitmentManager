using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateInterviews;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Candidate.Interviews;

public partial class CandidatePastInterviewsView : UserControl
{
	private readonly IMediator _mediator;
	public CandidatePastInterviewsView(IMediator mediator)
	{
		InitializeComponent();
		_mediator = mediator;
		this.Load += CandidateCurrentInterviewsView_Load;
		ChangeSize();
		stagesDgv.SizeChanged += delegate (object? sender, EventArgs args) { ChangeSize(); };
	}

	private async void CandidateCurrentInterviewsView_Load(object? sender, EventArgs e)
	=> await LoadPage();

	private async Task LoadPage()
	{
		var query = new GetCandidateInterviewsQuery(CandidateInterviewPredicate.Past);
		var response = await _mediator.Send(query);
		response = response.OrderBy(x => x.Date).ToList();
		stagesDgv.Fill(response, item => new object[]
		{
			item.Id,
			item.JobTitle,
			item.StageName,
			item.Date.HasValue ? item.Date.Value.ToString("dd/MM/yyyy HH:mm") : "Brak"
		});
	}

	private void ChangeSize()
	{
		stagesDgv.Columns[1].Width = (int)(stagesDgv.Width * 0.4);
		stagesDgv.Columns[2].Width = (int)(stagesDgv.Width * 0.4);
		stagesDgv.Columns[3].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		stagesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
	}
}
