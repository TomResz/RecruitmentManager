using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateInterviews;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingResult;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Candidate.News;

public partial class NewsView : UserControl
{
	private readonly IMediator _mediator;
	public NewsView(IMediator mediator)
	{
		InitializeComponent();
		_mediator = mediator;
		this.Load += NewsView_Load;
	}

	private async void NewsView_Load(object? sender, EventArgs e)
	{
		await Task.Delay(150);
		await FillStagesView();
		await FillUserview();
	}

	private async Task FillStagesView()
	{
		var stagesResponse = await _mediator.Send(new GetCandidateInterviewsQuery(CandidateInterviewPredicate.All));
		stagesResponse = stagesResponse.OrderBy(x => x.Date).ToList();
		stagesDgv.Fill(stagesResponse, item => new object[]
		{
			item.Id,
			item.JobTitle,
			item.StageName,
			item.Date.HasValue  ? item.Date.Value.ToString("HH:mm dd-MM-yyyy")  : "brak"
		});
		stagesDgv.Columns[1].Width = (int)(stagesDgv.Width * 0.4);
		stagesDgv.Columns[2].Width = (int)(stagesDgv.Width * 0.4);
		stagesDgv.Columns[3].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		stagesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
	}

	private async Task FillUserview()
	{
		var response = await _mediator.Send(new GetJobPostingResultQuery());
		userView.Fill(response, item => new object[] {
			item.JobName,
			item.IsSelected ? "Tak" : "Nie"
		});
		userView.Columns[0].Width = (int)(stagesDgv.Width * 0.4);
		userView.Columns[1].Width = (int)(stagesDgv.Width * 0.4);
		userView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		userView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
	}
}
