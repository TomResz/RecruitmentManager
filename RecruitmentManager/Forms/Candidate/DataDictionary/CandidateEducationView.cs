using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Add;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Delete;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Update;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetEducationsList;
using RecruitmentManager.Application.Functions.Common.Queries.GetEducationItem;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Forms.Candidate.DataDictionary;

public partial class CandidateEducationView : UserControl
{
	private readonly IMediator _mediator;
	public CandidateEducationView(IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		InitPictureBoxes();
		ChangeSize();
		educationDGV.SizeChanged += ((sender, args) => ChangeSize());
		educationDGV.CellClick += EducationDGV_CellClick;
		this.Load += CandidateEducationView_Load;
		SetupDatePickers();
	}

	private async void EducationDGV_CellClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (educationDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(educationDGV.CurrentRow.Cells[0].Value.ToString(), out var id))
			return;
		try
		{
			var response = await _mediator.Send(new GetEducationItemQuery(id));
			schoolNameTextBox.Text = response.SchoolName;
			majorTextBox.Text = response.Major;
			actualCheckBox.Checked = response.DateOfCompletion is null;
			beginDateTimePicker.Value = response.StartDate;
			endDateTimePicker.Value = response.DateOfCompletion ?? DateTime.Now;
			levelOfEduComboBox.SelectedIndex = response.LevelOfEducationId - 1;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void SetupDatePickers()
	{
		beginDateTimePicker.Format = DateTimePickerFormat.Custom;
		beginDateTimePicker.CustomFormat = "MMMM yyyy";
		endDateTimePicker.Format = DateTimePickerFormat.Custom;
		endDateTimePicker.CustomFormat = "MMMM yyyy";
	}

	private async void CandidateEducationView_Load(object? sender, EventArgs e) => await ReloadPage();

	private async Task ReloadPage()
	{
		var query = new GetEducationListQuery(null);
		var response = await _mediator.Send(query);
		educationDGV.Fill(response, item => new object[]
		{
			item.Id,
			item.SchoolName,
			item.Major ?? string.Empty,
			item.StartDate.ToString("MMMM yyyy"),
			item.DateOfCompletion.HasValue
				? item.DateOfCompletion.Value.ToString("MMMM yyyy")
				: "Aktualnie"
		});
	}

	private void ChangeSize()
	{
		educationDGV.Columns[1].Width = (int)(educationDGV.Width * 0.35);
		educationDGV.Columns[2].Width = (int)(educationDGV.Width * 0.25);
		educationDGV.Columns[3].Width = (int)(educationDGV.Width * 0.20);
		educationDGV.Columns[4].Width = (int)(educationDGV.Width * 0.20);
		educationDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		educationDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private void InitPictureBoxes()
	{
		majorPB.MouseHover += (s, args) => toolTip1.Show("Specjalizacja", majorPB);
		schoolPB.MouseHover += (s, args) => toolTip1.Show("Nazwa placówki edukacyjnej", schoolPB);
		levelOfEduPb.MouseHover += (s, args) => toolTip1.Show("Poziom wykształcenia", levelOfEduPb);
	}



	private LevelsOfEducation GetLevelOfEducation =>
		levelOfEduComboBox.Text switch
		{
			"Podstawowe" => LevelsOfEducation.Primary,
			"Średnie" => LevelsOfEducation.Secondary,
			"Wyższe" => LevelsOfEducation.Higher,
			_ => throw new InvalidDataException("Nie wybrano poziomu edukacji!")
		};
	private async void addBtn_Click(object sender, EventArgs e)
	{
		try
		{
			var command = new AddEducationCommand(
				schoolNameTextBox.Text,
				majorTextBox.Text,
				(int)GetLevelOfEducation,
				beginDateTimePicker.Value,
				actualCheckBox.Checked ? null : endDateTimePicker.Value);
			await _mediator.Send(command);
			MessageBox.Show("Dodano wpis!", "Dodawanie",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			Clear();
			await ReloadPage();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private void Clear()
	{
		schoolNameTextBox.Clear();
		majorTextBox.Clear();
		levelOfEduComboBox.SelectedIndex = 0;
		actualCheckBox.Checked = false;
	}

	private async void deleteBtn_Click(object sender, EventArgs e)
	{
		if (educationDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(educationDGV.CurrentRow.Cells[0].Value.ToString(), out Guid id))
			return;
		var confirmation = MessageBox.Show("Czy napewno usunąć ten wpis?",
			"Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.No)
			return;
		try
		{
			var command = new DeleteEducationCommand(id);
			await _mediator.Send(command);
			MessageBox.Show("Usunięto wpis!", "Usuwanie",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			Clear();
			await ReloadPage();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private async void editBtn_Click(object sender, EventArgs e)
	{
		if (educationDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(educationDGV.CurrentRow.Cells[0].Value.ToString(), out Guid id))
			return;
		var confirmation = MessageBox.Show("Czy napewno edytować ten wpis?",
			"Edycja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.No)
			return;
		try
		{
			var command = new UpdateEducationCommand(
				id,
				schoolNameTextBox.Text,
				majorTextBox.Text,
				(int)GetLevelOfEducation,
				beginDateTimePicker.Value,
				actualCheckBox.Checked ? null : endDateTimePicker.Value);
			await _mediator.Send(command);
			MessageBox.Show("Zaktualizowano wpis!", "Aktualizacja",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			Clear();
			await ReloadPage();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}