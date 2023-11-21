using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SetDateOfInterview;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetNotSetInterviews;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetSetInterviews;
using RecruitmentManager.Controls_Extensions;
using DateTimePickerFormat = System.Windows.Forms.DateTimePickerFormat;

namespace RecruitmentManager.Forms.Manager.StagesSetup;

public partial class StagesSetupView : UserControl
{
	private readonly IMediator _mediator;
	public StagesSetupView(IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		CalendarSetUp();
		DgvSizeSetup();
		stagesDgv.SizeChanged += (s, args) => DgvSizeSetup();
		this.Load += StagesSetupView_Load;

	}

	private void DgvSizeSetup()
	{
		stagesDgv.Columns[1].Width = (int)(stagesDgv.Width * 0.3);
		stagesDgv.Columns[2].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[3].Width = (int)(stagesDgv.Width * 0.25);
		stagesDgv.Columns[4].Width = (int)(stagesDgv.Width * 0.25);
		stagesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		stagesDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}
	private async void StagesSetupView_Load(object? sender, EventArgs e)
		=> await PageReload();

	private void CalendarSetUp()
	{
		datePicker.Format = DateTimePickerFormat.Custom;
		datePicker.CustomFormat = "dd-MM-yyyy HH:mm";
	}

	private async Task PageReload()
	{
		List<InterviewDto> response;
		if (!toCheckCB.Checked)
			response = await _mediator.Send(new GetSetInterviewsQuery());
		else
			response = await _mediator.Send(new GetNotSetInterviewsQuery());

		stagesDgv.Fill(response, item => new object[]
		{
			item.Id,
			item.JobTitle,
			item.StageName,
			item.CandidateFullName,
			item.Date.HasValue ? item.Date.Value.ToString("dd-MM-yyyy HH:mm") : "Brak"
		});
	}

	private async void UpdateBtn_Click(object sender, EventArgs e)
	{
		if (stagesDgv.CurrentRow is null ||
		   !Guid.TryParse(stagesDgv.CurrentRow.Cells[0].Value.ToString(), out var id) ||
		   DateTime.TryParse(stagesDgv.CurrentRow.Cells[4].Value.ToString(), out var date))
			return;
		try
		{
			var command = new SetDateOfInterviewCommand(id, datePicker.Value);
			await _mediator.Send(command);
			MessageBox.Show("Dodano godzinę rozmowy!", "Dodawanie", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			await PageReload();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private async void toCheckCB_CheckedChanged(object sender, EventArgs e) => await PageReload();
}