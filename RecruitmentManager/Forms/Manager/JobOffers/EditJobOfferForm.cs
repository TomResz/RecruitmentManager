using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.UpdateJobOffer;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetJobOfferDetailsToEdit;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.RecruiterList;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class EditJobOfferForm : Form
{
	private readonly IMediator _mediator;
	private readonly IJobOfferContext _context;

	public EditJobOfferForm(
		IJobOfferContext context,
		IMediator mediator)
	{
		_context = context;
		_mediator = mediator;
		InitializeComponent();
		this.Load += LoadData;
		InitializePictureBoxAction();
		InitializeDateTimePickers();
	}

	private void InitializePictureBoxAction()
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

	private async void LoadData(object? sender, EventArgs e)
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
		var result = await _mediator.Send(
			new GetJobOfferDetailsToEditQuery(_context.Id));
		recruitmentStagesDGV.Fill(result.RecruitmentStagesDtos, item => new object[]
		{
			item.Id,
			item.EmployeeId,
			item.Order,
			item.GradeWeight,
			item.StageName,
			item.FullName
		});
		titleTextBox.Text = result.Title;
		descriptionTextBox.Text = result.Description;
		beginDateDatePicker.Value = result.CreatedDate;
		endDateDatePicker.Value = result.EndDate;
		counterControl.Value = (decimal)result.NumberOfPositions;
	}
	private void recruitmentStagesDGV_SizeChanged(object sender, EventArgs e)
	{
		recruitmentStagesDGV.Columns[2].Width = (int)(recruitmentStagesDGV.Width * 0.15);
		recruitmentStagesDGV.Columns[3].Width = (int)(recruitmentStagesDGV.Width * 0.10);
		recruitmentStagesDGV.Columns[4].Width = (int)(recruitmentStagesDGV.Width * 0.30);
		recruitmentStagesDGV.Columns[5].Width = (int)(recruitmentStagesDGV.Width * 0.30);
		recruitmentStagesDGV.Columns[6].Width = (int)(recruitmentStagesDGV.Width * 0.15);
		recruiterDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		recruiterDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	public List<RecruitmentStagesToEditDto> GetStages()
	{
		var list = new List<RecruitmentStagesToEditDto>();
		foreach (DataGridViewRow row in recruitmentStagesDGV.Rows)
		{
			var id = Guid.Parse(row.Cells[0].Value?.ToString() ?? throw new InvalidOperationException());
			var workerId = Guid.Parse(row.Cells[1].Value?.ToString() ?? throw new InvalidOperationException());
			var order = int.Parse(row.Cells[2].Value?.ToString() ?? throw new InvalidOperationException());
			var weight = int.Parse(row.Cells[3].Value?.ToString() ?? throw new InvalidOperationException());
			var name = row.Cells[4].Value?.ToString();
			list.Add(new RecruitmentStagesToEditDto()
			{
				Id = id,
				EmployeeId = workerId,
				Order = order,
				GradeWeight = weight,
				StageName = name
			});
		}
		return list;
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
	private void addRecruitmentStageBtn_Click_1(object sender, EventArgs e)
	{
		try
		{
			var id = Guid.NewGuid();
			var worker = GetWorker();
			var order = orderUpAndDown.Value;
			var weight = weightUpAndDown.Value;
			var name = !string.IsNullOrWhiteSpace(stageNameTitle.Text)
				? stageNameTitle.Text
				: throw new Exception("Podaj nazwę etapu rekrutacji!");
			recruitmentStagesDGV.Rows.Add(new object[]
			{
				id,
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


	private async void editBtn_Click(object sender, EventArgs e)
	{
		try
		{
			editBtn.Enabled = false;
			var command = new UpdateJobOfferCommand(
				_context.Id,
				titleTextBox.Text,
				descriptionTextBox.Text,
				(int)counterControl.Value,
				beginDateDatePicker.Value,
				endDateDatePicker.Value,
				GetStages());
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie edytowano ofertę pracy.", "Edytowanie ofert pracy",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			await Task.Delay(500);
			this.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally
		{
			editBtn.Enabled = true;
		}
	}



	private void recruitmentStagesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e is { RowIndex: >= 0, ColumnIndex: 6 })
			{
				var confirmation = MessageBox.Show("Czy napewno usunąć ten etap?", "Usuwanie",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (confirmation == DialogResult.No)
					return;
				recruitmentStagesDGV.Rows.RemoveAt(e.RowIndex);
			}
		}

	}