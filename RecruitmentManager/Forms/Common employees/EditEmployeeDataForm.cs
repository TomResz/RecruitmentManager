// Ignore Spelling: Admin

using DocumentFormat.OpenXml.Office2010.Excel;
using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Common;
using RecruitmentManager.Application.Functions.Worker_Functions.Common.Commands.EditEmployeeData;
using RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager.Forms.Admin;

public partial class EditEmployeeDataForm : Form
{
	private readonly IWorkerSessionContext _sessionContext;
	private readonly IMediator _mediator;
	private readonly ISubtitles _subtitles;

	private EmployeeDataDto employee;

	public EditEmployeeDataForm(
		IWorkerSessionContext sessionContext,
		IMediator mediator,
		ISubtitles subtitles)
	{
		InitializeComponent();
		_sessionContext = sessionContext;
		_mediator = mediator;
		_subtitles = subtitles;

		this.Load += EditEmployeeDataForm_Load;
	}

	private async void EditEmployeeDataForm_Load(object? sender, EventArgs e)
	{
		var query = new GetEmployeeDataQuery(Id: _sessionContext.WorkerId ??
			throw new ArgumentNullException(nameof(_sessionContext.WorkerId)));
		employee = await _mediator.Send(query);
		InitLabels();
		FillFields();
	}
	private void InitLabels()
	{
		firstNameLabel.Text = _subtitles.FirstName;
		lastNameLabel.Text = _subtitles.LastName;
		phoneNumberLabel.Text = _subtitles.PhoneNumber;

	}
	private void FillFields()
	{
		firstNameTb.Text = employee.FirstName;
		lastNameTb.Text = employee.LastName;
		emailTb.Text = employee.Email;
		birthDatePicker.Value = employee.BirthDate ?? DateTime.Now;
		phoneNumberTb.Text = employee.PhoneNumber ?? string.Empty;
		emailTb.ReadOnly = true;
	}

	private void firstNameTb_TextChanged(object sender, EventArgs e)
		=> firstNameLabel.Text = string.IsNullOrEmpty(firstNameTb.Text)
		? _subtitles.FirstName : string.Empty;

	private void lastNameTb_TextChanged(object sender, EventArgs e)
		=> lastNameLabel.Text = string.IsNullOrEmpty(lastNameTb.Text)
		? _subtitles.LastName : string.Empty;

	private void phoneNumberTb_TextChanged(object sender, EventArgs e)
		=> phoneNumberLabel.Text = string.IsNullOrEmpty(phoneNumberTb.Text)
		? _subtitles.PhoneNumber : string.Empty;

	private async void editDataBtn_Click(object sender, EventArgs e)
	{

		try
		{
			editDataBtn.Enabled = false;
			var command = new EditEmployeeDataCommand
				(Id: (Guid)_sessionContext.WorkerId,
				FirstName: firstNameTb.Text,
				LastName: lastNameTb.Text,
				PhoneNumber: phoneNumberTb.Text,
				BirthDate: birthDatePicker.Value);
			await _mediator.Send(command);
			MessageBox.Show(
				 text: "Edytowane pomyślnie dane użytkownika!",
				caption: "Edycja danych.",
				   buttons: MessageBoxButtons.OK,
				   icon: MessageBoxIcon.Information);

			var role = _sessionContext.GetRole;

			_sessionContext.SetWorker((Guid)_sessionContext.WorkerId,
				  role,
				  firstNameTb.Text + " " + lastNameTb.Text);
			await Task.Delay(500);
			this.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally
		{
			editDataBtn.Enabled = true;
		}
	}
}
