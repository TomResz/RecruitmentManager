using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ResetPassword;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager.Forms.Admin;

public partial class ResetCandidatePasswordForm : Form
{


	private readonly IMediator _mediator;
	private readonly IUserBasicDataContext _userBasicDataContext;
	private readonly ISubtitles _label;
	public ResetCandidatePasswordForm(
		IMediator mediator,
		IUserBasicDataContext userBasicDataContext,
		ISubtitles label)
	{
		InitializeComponent();
		_label = label;
		_mediator = mediator;
		_userBasicDataContext = userBasicDataContext;
		emailTb.Text = _userBasicDataContext.GetEmail;
		emailTb.ReadOnly = true;
		InitializeTextBoxes();
		InitToolTip();
	}
	private void InitToolTip()
	{
		var toolTip = new ToolTip();
		passwordTb.MouseHover += (s, args) => toolTip.Show("Tu należy wpisać hasło.", passwordTb);
		confirmedPasswdTb.MouseHover += (s, args) => toolTip.Show("Tu należy powtórzyć hasło.", confirmedPasswdTb);
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
		var command = new CandidateResetPasswordCommand(
			CandidateId: _userBasicDataContext.GetId,
			Password: passwordTb.Text,
			ConfirmedPassword: confirmedPasswdTb.Text);

		var confirmation = MessageBox.Show("Czy napewno chcesz zmienić hasło?", "Zmiana hasła.",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.No)
			return;

		try
		{
			await _mediator.Send(command);
			MessageBox.Show("Hasło zostało zmienione!", "Zmiana hasła!",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(
				text: ex.Message,
				caption: "Błąd.",
				buttons: MessageBoxButtons.OK,
				   icon: MessageBoxIcon.Error);
		}
	}
}
