using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Login;
using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager;

public partial class LoginCandidateForm : Form
{
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateSessionContext _candidateSessionContext;

	private const string PasswordText = "Hasło";
	private const string EmailText = "E-Mail";
	private const char PasswordChar = '●';
	public LoginCandidateForm(
		IMediator mediator,
		IServiceProvider serviceProvider,
		ICandidateSessionContext candidateSessionContext)
	{
		InitializeComponent();
		InitializeTextBoxesAndLabels();
		_mediator = mediator;
		_serviceProvider = serviceProvider;
		_candidateSessionContext = candidateSessionContext;
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
		try
		{
			var id = await _mediator.Send(loginCommand);
			_candidateSessionContext.SetId(id);
			MessageBox.Show("Zalogowano!");
		}
		catch (Exception ex)
		{
			MessageBox.Show(text: ex.Message,
				caption: "Logowanie się nie powiodło!",
				  buttons: MessageBoxButtons.OK,
				  icon: MessageBoxIcon.Error);
		}
	}

	private void backToMainFormLabel_Click(object sender, EventArgs e)
	{
		var mainForm = _serviceProvider.GetRequiredService<MainForm>();
		this.Hide();
		mainForm.FormClosed += (s, args) => this.Close();
		mainForm.Show();
	}
}
