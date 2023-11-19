using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Recruiter.Stages;

public partial class FutureStagesView : UserControl
{
	private readonly IMediator _mediator;
	public FutureStagesView(IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		DgvSizeSetup();
		stagesDgv.SizeChanged += (s, args) => DgvSizeSetup();
		this.Load += CurrentStagesView_Load;
	}
	private async void CurrentStagesView_Load(object? sender, EventArgs e) => await LoadData();

	private async Task LoadData()
	{
		var query = new GetInterviewsByInterviewPredicateQuery(InterviewPredicate.Future);
		var response = await _mediator.Send(query);
		stagesDgv.Fill(response, item => new object[]
		{
			item.Id,
			item.JobTitle,
			item.StageName,
			item.CandidateFullName,
			item.Date.HasValue ? item.Date.Value.ToString("dd-MM-yyyy HH:mm") : "Brak"
		});
	}

	private void DgvSizeSetup()
	{
		stagesDgv.Columns[1].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[2].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[3].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[4].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[5].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		stagesDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}
}