using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Register;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager.Forms.Admin;

public partial class AddCandidateForm : Form
{
	private readonly IMediator _mediator;
	private readonly ISubtitles _subtitles;

	public AddCandidateForm(
		IMediator mediator,
		ISubtitles subtitles)
	{
		InitializeComponent();
		_mediator = mediator;
		_subtitles = subtitles;

		InitializeTextBoxesAndLabels();
	}

	private void InitializeTextBoxesAndLabels()
	{
		firstNameLabel.Text = _subtitles.FirstName;
		lastNameLabel.Text = _subtitles.LastName;
		emailLabel.Text = _subtitles.Email;
		passwordLabel.Text = _subtitles.Password;
		confirmedPasswdLabel.Text = _subtitles.RepeatPassword;
		passwordTb.PasswordChar = _subtitles.PasswordSym;
		confirmedPasswdTb.PasswordChar = _subtitles.PasswordSym;
	}

	private void firstNameTb_TextChanged(object sender, EventArgs e)
		=> firstNameLabel.Text = string.IsNullOrEmpty(firstNameTb.Text)
		? _subtitles.FirstName : string.Empty;

	private void lastNameTb_TextChanged(object sender, EventArgs e)
		=> lastNameLabel.Text = string.IsNullOrEmpty(lastNameTb.Text)
		? _subtitles.LastName : string.Empty;

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? _subtitles.Email : string.Empty;

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? _subtitles.Password : string.Empty;

	private void confirmedPasswdTb_TextChanged(object sender, EventArgs e)
		=> confirmedPasswdLabel.Text = string.IsNullOrEmpty(confirmedPasswdTb.Text)
		? _subtitles.RepeatPassword : string.Empty;

	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
	{
		if (showPasswdCB.Checked)
		{
			passwordTb.PasswordChar = default;
			confirmedPasswdTb.PasswordChar = default;
		}
		else
		{
			passwordTb.PasswordChar = _subtitles.PasswordSym;
			confirmedPasswdTb.PasswordChar = _subtitles.PasswordSym;
		}
	}

	private async void registerBtn_Click(object sender, EventArgs e)
	{
		registerBtn.Enabled = false;
		var command = new RegisterCandidateCommand(
			FirstName: firstNameTb.Text,
			LastName: lastNameTb.Text,
			Email: emailTb.Text,
			Password: passwordTb.Text,
			ConfirmedPassword: confirmedPasswdTb.Text);
		try
		{
			await _mediator.Send(command);
			MessageBox.Show("Domyślnie dodano nowego kandydata!", "Dodawanie kandydatów.",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			await Task.Delay(millisecondsDelay: 500);
			ClearFields();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally
		{
			registerBtn.Enabled = true;
		}
	}
	void ClearFields()
	{
		firstNameTb.Clear();
		lastNameTb.Clear();
		emailTb.Clear();
		passwordTb.Clear();
		confirmedPasswdTb.Clear();
	}
}
