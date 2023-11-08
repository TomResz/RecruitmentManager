using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CreateJobOffer;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.RecruiterList;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class AddJobOfferForm : Form
{
	private readonly IMediator _mediator;
	public AddJobOfferForm(
		IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		InitializePictureBoxes();
		InitializeDateTimePickers();
		this.Load += LoadRecruiters;
	}

	private async void LoadRecruiters(object? sender, EventArgs e)
	{
		var recruiterDtos = await _mediator.Send(new GetRecruitersListQuery());
		recruiterDGV.Fill(recruiterDtos, item => new object[]
		{
			item.Id,
			false,
			item.Email,
			item.FullName
		});
		SetDgvSize();
	}

	private void SetDgvSize()
	{
		recruiterDGV.Columns[1].Width = (int)(recruiterDGV.Width * 0.15);
		recruiterDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		recruiterDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private void InitializeDateTimePickers()
	{
		beginDateDatePicker.Format = DateTimePickerFormat.Custom;
		endDateDatePicker.Format = DateTimePickerFormat.Custom;
		beginDateDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";
		endDateDatePicker.CustomFormat = "dd/MM/yyyy HH:mm";
	}

	private void InitializePictureBoxes()
	{
		titlePB.MouseHover += (
			s,
			args) => toolTip.Show("Tytuł", titlePB);
		descriptionPB.MouseHover += (
			s,
			args) => toolTip.Show("Opis", descriptionPB);
		beginDatePB.MouseHover += (
				s,
				args) =>
			toolTip.Show("Data rozpoczęcia rekrutacji", beginDatePB);
		endDatePB.MouseHover += (
			s,
			args) => toolTip.Show("Data zakończenia rekrutacji", endDatePB);
		numberOfPlacesPB.MouseHover += (
			s,
			args) => toolTip.Show("Ilość miejsc", numberOfPlacesPB);
		stageNamePB.MouseHover += (
				s,
				args) =>
			toolTip.Show("Nazwa Etapu Rekrutacji", stageNamePB);
		weightPB.MouseHover += (
				s,
				args)
			=> toolTip.Show("Waga Etapu Rekrutacji", weightPB);
		stageOrderPB.MouseHover += (
				s,
				args) =>
			toolTip.Show("Kolejność Etapu Rekrutacji", stageOrderPB);
	}

	public List<RecruitmentStagesDto> GetStages()
	{
		var list = new List<RecruitmentStagesDto>();
		foreach (DataGridViewRow row in recruitmentStagesDGV.Rows)
		{
			var workerId = Guid.Parse(row.Cells[0].Value?.ToString() ?? throw new InvalidOperationException());
			var order = int.Parse(row.Cells[1].Value?.ToString() ?? throw new InvalidOperationException());
			var weight = int.Parse(row.Cells[2].Value?.ToString() ?? throw new InvalidOperationException());
			var name = row.Cells[3].Value?.ToString();
			list.Add(new RecruitmentStagesDto()
			{
				EmployeeId = workerId,
				Order = order,
				GradeWeight = weight,
				StageName = name
			});
		}
		return list;
	}

	private async void saveBtn_Click(object sender, EventArgs e)
	{
		try
		{
			saveBtn.Enabled = false;
			var command = new CreateJobOfferCommand(titleTextBox.Text,
				descriptionTextBox.Text,
				(int)counterControl.Value,
				beginDateDatePicker.Value,
				endDateDatePicker.Value,
				GetStages());
			await _mediator.Send(command);
			await Task.Delay(500);
			MessageBox.Show("Dodano ogłoszenie o pracę!",
				"Dodawanie ogłoszeń!",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			this.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
		finally
		{
			saveBtn.Enabled = true;
		}
	}

	private void recruiterDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (recruiterDGV.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
		{
			DataGridViewCheckBoxCell clickedCheckbox = (DataGridViewCheckBoxCell)recruiterDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
			foreach (DataGridViewRow row in recruiterDGV.Rows)
			{
				if (row.Index != e.RowIndex)
				{
					DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells[e.ColumnIndex];
					checkbox.Value = false;
				}
			}
		}
	}

	private Tuple<Guid, string> GetWorker()
	{
		foreach (DataGridViewRow row in recruiterDGV.Rows)
		{
			if (row.Cells[1] is DataGridViewCheckBoxCell checkBoxRow)
			{
				if (Convert.ToBoolean(checkBoxRow.Value) is true)
				{
					var id = Guid.Parse(recruiterDGV.Rows[row.Index].Cells[0].Value.ToString()
										?? throw new ArgumentException(""));
					string fullName = recruiterDGV.Rows[row.Index].Cells[3].Value.ToString() ??
									  throw new ArgumentException();
					return new(id, fullName);
				}
			}
		}
		throw new Exception("Nie wybrano użytkownika!");
	}
	private void addRecruitmentStageBtn_Click(object sender, EventArgs e)
	{
		try
		{
			var worker = GetWorker();
			var order = orderUpAndDown.Value;
			var weight = weightUpAndDown.Value;
			var name = !string.IsNullOrWhiteSpace(stageNameTitle.Text)
				? stageNameTitle.Text
				: throw new Exception("Podaj nazwę etapu rekrutacji!");
			recruitmentStagesDGV.Rows.Add(new object[]
			{
				worker.Item1,
				order,
				weight,
				name,
				worker.Item2
			});
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Nieprawidłowe dane!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private void recruitmentStagesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e is { RowIndex: >= 0, ColumnIndex: 5 })
		{
			var confirmation = MessageBox.Show("Czy napewno usunąć ten etap?", "Usuwanie",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirmation == DialogResult.No)
				return;
			recruitmentStagesDGV.Rows.RemoveAt(e.RowIndex);
		}
	}


	private void recruitmentStagesDGV_SizeChanged(object sender, EventArgs e)
	{
		recruitmentStagesDGV.Columns[1].Width = (int)(recruitmentStagesDGV.Width * 0.15);
		recruitmentStagesDGV.Columns[2].Width = (int)(recruitmentStagesDGV.Width * 0.10);
		recruitmentStagesDGV.Columns[3].Width = (int)(recruitmentStagesDGV.Width * 0.30);
		recruitmentStagesDGV.Columns[4].Width = (int)(recruitmentStagesDGV.Width * 0.30);
		recruitmentStagesDGV.Columns[5].Width = (int)(recruitmentStagesDGV.Width * 0.15);
		recruiterDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		recruiterDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}
}