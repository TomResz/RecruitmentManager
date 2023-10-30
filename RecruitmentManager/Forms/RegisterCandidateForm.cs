using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Register;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager;

public partial class RegisterCandidateForm : Form
{

	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private ISubtitles _label;
	public RegisterCandidateForm(
		IMediator mediator,
		IServiceProvider serviceProvider,
		ISubtitles label)
	{
		InitializeComponent();
		_mediator = mediator;
		_serviceProvider = serviceProvider;
		_label = label;
		InitializeTextBoxesAndLabels();
	}

	private void InitializeTextBoxesAndLabels()
	{
		firstNameLabel.Text = _label.FirstName;
		lastNameLabel.Text = _label.LastName;
		emailLabel.Text = _label.Email;
		passwordLabel.Text = _label.Password;
		confirmedPasswdLabel.Text = _label.RepeatPassword;
		passwordTb.PasswordChar = _label.PasswordSym;
		confirmedPasswdTb.PasswordChar = _label.PasswordSym;
	}
	private void firstNameTb_TextChanged(object sender, EventArgs e)
		=> firstNameLabel.Text = string.IsNullOrEmpty(firstNameTb.Text)
			? _label.FirstName : "";
	private void lastNameTb_TextChanged(object sender, EventArgs e)
	=> lastNameLabel.Text = string.IsNullOrEmpty(lastNameTb.Text)
		? _label.LastName : "";

	private void loginLabel_Click(object sender, EventArgs e)
	{
		this.Hide();
		var loginForm = _serviceProvider.GetRequiredService<LoginCandidateForm>();
		loginForm.Closed += (s, args) => this.Close();
		loginForm.Show();
	}

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? _label.Email : "";

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? _label.Password : "";

	private void confirmedPasswdTb_TextChanged(object sender, EventArgs e)
		=> confirmedPasswdLabel.Text = string.IsNullOrEmpty(confirmedPasswdTb.Text)
		? _label.RepeatPassword : "";

	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
	{
		if (!showPasswdCB.Checked)
		{
			passwordTb.PasswordChar = _label.PasswordSym;
			confirmedPasswdTb.PasswordChar = _label.PasswordSym;
		}
		else
		{
			passwordTb.PasswordChar = default(char);
			confirmedPasswdTb.PasswordChar = default(char);
		}
	}

	private async void registerBtn_Click(object sender, EventArgs e)
	{
		var register = new RegisterCandidateCommand(
			 FirstName: firstNameTb.Text,
			 LastName: lastNameTb.Text,
			 Email: emailTb.Text,
			 Password: passwordTb.Text,
			 ConfirmedPassword: confirmedPasswdTb.Text);
		try
		{
			await _mediator.Send(register);
			registerBtn.Enabled = false;
			MessageBox.Show("Zarejestrowano użytkownika!", "Rejestracja.",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
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
