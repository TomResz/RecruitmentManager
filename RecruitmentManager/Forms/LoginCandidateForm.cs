using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate.Login;

namespace RecruitmentManager;

public partial class LoginCandidateForm : Form
{
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;

	private const string PasswordText = "Hasło";
	private const string EmailText = "E-Mail";
	private const char PasswordChar = '●';
	public LoginCandidateForm(
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
		passwordLabel.Text = PasswordText;
		emailLabel.Text = EmailText;
		passwordTb.PasswordChar = PasswordChar;
	}

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? EmailText
		: "";

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? PasswordText
		: "";

	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
		=> passwordTb.PasswordChar = !showPasswdCB.Checked
		? PasswordChar
		: default(char);

	private void label2_Click(object sender, EventArgs e)
	{
		var registerForm = _serviceProvider.GetRequiredService<RegisterCandidateForm>();
		this.Hide();
		registerForm.FormClosed += (s, args) => this.Close();
		registerForm.Show();
	}

	private async void loginBtn_Click(object sender, EventArgs e)
	{
		var loginCommand = new LoginCandidateCommand(
			  Email: emailTb.Text,
			Password: passwordTb.Text);
		var id = await _mediator.Send(loginCommand);
	}

	private void backToMainFormLabel_Click(object sender, EventArgs e)
	{
		var mainForm = _serviceProvider.GetRequiredService<MainForm>();
		this.Hide();
		mainForm.FormClosed += (s, args) => this.Close();
		mainForm.Show();
	}
}
