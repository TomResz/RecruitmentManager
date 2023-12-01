using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Add;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Delete;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Update;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetExperienceList;
using RecruitmentManager.Application.Functions.Common.Queries.GetExperienceItem;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Candidate.DataDictionary;

public partial class CandidateExperienceView : UserControl
{
	private readonly IMediator _mediator;
	public CandidateExperienceView(IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		ChangeSizeSettings();
		experienceDGV.SizeChanged += (s, args) => ChangeSizeSettings();
		PictureBoxesAction();
		DatePickersSetting();
		experienceDGV.CellContentDoubleClick += ExperienceDGV_CellContentDoubleClick;
		this.Load += CandidateExperienceView_Load;
	}

	private async void ExperienceDGV_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (experienceDGV.CurrentRow is null)
			return;
		if (Guid.TryParse(experienceDGV.CurrentRow.Cells[0].Value.ToString(), out var uid))
		{
			var query = new GetExperienceItemQuery(uid);
			var response = await _mediator.Send(query);
			titleTextBox.Text = response.JobName;
			companyNameTextBox.Text = response.CompanyName;
			descriptionTextBox.Text = response.Description;
			beginDateTimePicker.Value = response.StartDateOfWork;
			if (response.OfCompletionOfWork is null)
			{
				actualCheckBox.Checked = true;
				return;
			}
			actualCheckBox.Checked = false;
			endDateTimePicker.Value = (DateTime)response.OfCompletionOfWork;

		}

	}

	private async void CandidateExperienceView_Load(object? sender, EventArgs e)
		=> await LoadDGV();

	private void DatePickersSetting()
	{
		beginDateTimePicker.Format = DateTimePickerFormat.Custom;
		endDateTimePicker.Format = DateTimePickerFormat.Custom;
		beginDateTimePicker.CustomFormat = "MMMMM yyyy";
		endDateTimePicker.CustomFormat = "MMMM yyyy";
	}
	private void PictureBoxesAction()
	{
		titleTextBox.MouseHover += (s, args) => toolTip1.Show("Tu należy wpisać nazwę pracy.", titleTextBox);
		companyNamePB.MouseHover += (s, args) => toolTip1.Show("Tu należy wpisać nazwę firmy.", companyNamePB);
		descriptionTextBox.MouseHover += (s, args) => toolTip1.Show("Opisz tą pracę.", descriptionTextBox);
		titlePB.MouseHover += (s, args) => toolTip1.Show("Nazwa stanowiska", titlePB);
		companyNamePB.MouseHover += (s, args) => toolTip1.Show("Nazwa firmy", companyNamePB);
		descriptionPb.MouseHover += (s, args) => toolTip1.Show("Opis stanowiska", descriptionPb);
	}
	private void ChangeSizeSettings()
	{
		experienceDGV.Columns[1].Width = (int)(experienceDGV.Width * 0.3);
		experienceDGV.Columns[2].Width = (int)(experienceDGV.Width * 0.3);
		experienceDGV.Columns[3].Width = (int)(experienceDGV.Width * 0.20);
		experienceDGV.Columns[4].Width = (int)(experienceDGV.Width * 0.20);
		experienceDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		experienceDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}


	private async Task LoadDGV()
	{
		var query = new GetExperienceListQuery(null);
		var response = await _mediator.Send(query);
		experienceDGV.Fill(response, item => new object[]
		{
			item.Id,
			item.JobName,
			item.CompanyName,
			item.StartDateOfWork.ToString("MMMM yyyy"),
			item.OfCompletionOfWork.HasValue
				? item.OfCompletionOfWork.Value.ToString("MMMM yyyy")
				: "Do tej pory"
		});
	}

	private async void addBtn_Click(object sender, EventArgs e)
	{
		try
		{
			var command = new AddExperienceCommand(
				titleTextBox.Text,
				companyNameTextBox.Text,
				descriptionTextBox.Text,
				beginDateTimePicker.Value,
				actualCheckBox.Checked ? null : endDateTimePicker.Value);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie dodano!", "Dodawanie",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			ClearFields();
			await LoadDGV();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}

	}

	private void ClearFields()
	{
		titleTextBox.Clear();
		companyNameTextBox.Clear();
		descriptionTextBox.Clear();
		actualCheckBox.Checked = false;
	}

	private async void editBtn_Click(object sender, EventArgs e)
	{
		if (experienceDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(experienceDGV.CurrentRow.Cells[0].Value.ToString(), out var uid))
			return;

		var confirmation = MessageBox.Show("Czy napewno zaktualizować ten wpis?", "Aktualizacja",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.No)
			return;

		try
		{
			var command = new UpdateExperienceCommand(
				uid,
				titleTextBox.Text,
				companyNameTextBox.Text,
				descriptionTextBox.Text,
				beginDateTimePicker.Value,
				actualCheckBox.Checked ? null : endDateTimePicker.Value);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie zaktualizowano!", "Aktualizowanie",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			ClearFields();
			await LoadDGV();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}

	}

	private async void deleteBtn_Click(object sender, EventArgs e)
	{
		if (experienceDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(experienceDGV.CurrentRow.Cells[0].Value.ToString(), out var uid))
			return;
		var confirmation = MessageBox.Show("Czy napewno usunąć ten wpis?", "Aktualizacja",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.No)
			return;
		try
		{
			var command = new DeleteExperienceCommand(uid);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie usunięto!", "Usuwanie",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			ClearFields();
			await LoadDGV();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}
}