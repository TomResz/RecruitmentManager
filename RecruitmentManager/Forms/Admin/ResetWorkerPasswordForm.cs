using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.EditWorkerPassword;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager.Forms;

public partial class ResetWorkerPasswordForm : Form
{
	private readonly IMediator _mediator;
	private readonly IUserDataToEditContext _workerDataToEditContext;
	private readonly ISubtitles _label;
	public ResetWorkerPasswordForm(
		IMediator mediator,
		IUserDataToEditContext workerDataToEditContext,
		ISubtitles label)
	{
		InitializeComponent();
		_mediator = mediator;
		_workerDataToEditContext = workerDataToEditContext;
		emailTb.ReadOnly = true;
		emailTb.Text = _workerDataToEditContext.GetEmail;
		_label = label;
		InitializeTextBoxes();
	}

	private void InitializeTextBoxes()
	{
		passwordLabel.Text = _label.NewPassword;
		confirmedPasswdLabel.Text = _label.RepeatNewPassword;
		passwordTb.PasswordChar = _label.PasswordSym;
		confirmedPasswdTb.PasswordChar = _label.PasswordSym;
	}

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? _label.NewPassword : "";

	private void confirmedPasswdTb_TextChanged(object sender, EventArgs e)
		=> confirmedPasswdLabel.Text = string.IsNullOrEmpty(confirmedPasswdTb.Text)
		? _label.RepeatNewPassword : "";

	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
	{
		if (showPasswdCB.Checked)
		{
			passwordTb.PasswordChar = default;
			confirmedPasswdTb.PasswordChar = default;
		}
		else
		{
			passwordTb.PasswordChar = _label.PasswordSym;
			confirmedPasswdTb.PasswordChar = _label.PasswordSym;
		}
	}

	private async void changePasswordBtn_Click(object sender, EventArgs e)
	{
		var confirmationMessage = MessageBox.Show("Czy chcesz napewno edytować hasło?",
			"Edycja hasła.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmationMessage == DialogResult.Yes)
		{
			try
			{
				var command = new EditWorkerPasswordCommand(_workerDataToEditContext.GetId,
					passwordTb.Text, confirmedPasswdTb.Text);
				await _mediator.Send(command);
				MessageBox.Show("Hasło zostało zmienione!", "Zmiana hasła.",
					  MessageBoxButtons.OK,
							MessageBoxIcon.Information);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Błąd.", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}
}
