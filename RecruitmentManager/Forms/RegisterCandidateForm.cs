using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate.Register;

namespace RecruitmentManager;

public partial class RegisterCandidateForm : Form
{
	private const string Email = "E-Mail";
	private const string Password = "Hasło";
	private const string ConfirmedPassword = "Powtórz Hasło";


	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;

	public RegisterCandidateForm(
		IMediator mediator,
		IServiceProvider serviceProvider)
	{
		InitializeComponent();
		InitializeTextBoxesAndLabels();
		_mediator = mediator;
		_serviceProvider = serviceProvider;
	}

	private void InitializeTextBoxesAndLabels()
	{
		emailLabel.Text = Email;
		passwordLabel.Text = Password;
		confirmedPasswdLabel.Text = ConfirmedPassword;
		passwordTb.PasswordChar = '●';
		confirmedPasswdTb.PasswordChar = '●';
	}

	private void loginLabel_Click(object sender, EventArgs e)
	{
		this.Hide();
		var loginForm = _serviceProvider.GetRequiredService<LoginCandidateForm>();
		loginForm.Closed += (s, args) => this.Close();
		loginForm.Show();
	}

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? Email : "";

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? Password : "";

	private void confirmedPasswdTb_TextChanged(object sender, EventArgs e)
		=> confirmedPasswdLabel.Text = string.IsNullOrEmpty(confirmedPasswdTb.Text)
		? ConfirmedPassword : "";

	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
	{
		if (!showPasswdCB.Checked)
		{
			passwordTb.PasswordChar = '●';
			confirmedPasswdTb.PasswordChar = '●';
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
			 Email: emailTb.Text,
			 Password: passwordTb.Text,
			 ConfirmedPassword: confirmedPasswdTb.Text);
		try
		{
			await _mediator.Send(register);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}
