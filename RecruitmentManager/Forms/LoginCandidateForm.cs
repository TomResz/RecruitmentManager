using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Login;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Candidate;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager;

public partial class LoginCandidateForm : Form
{
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly ISubtitles _label;
	public LoginCandidateForm(
		IMediator mediator,
		IServiceProvider serviceProvider,
		ICandidateSessionContext candidateSessionContext,
		ISubtitles label)
	{
		InitializeComponent();
		_mediator = mediator;
		_serviceProvider = serviceProvider;
		_candidateSessionContext = candidateSessionContext;
		_label = label;
		InitializeTextBoxesAndLabels();
		InitialToolTipActions();
	}
	private void InitialToolTipActions()
	{
		var tooltip = new ToolTip();
		emailTb.MouseHover += (s, args) => tooltip.Show("Tu należy wpisać adres email!", emailTb);
		passwordTb.MouseHover += (s, args) => tooltip.Show("Tu należy wpisać hasło!", passwordTb);
	}



	private void InitializeTextBoxesAndLabels()
	{
		passwordLabel.Text = _label.Password;
		emailLabel.Text = _label.Email;
		passwordTb.PasswordChar = _label.PasswordSym;
	}

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? _label.Email
		: "";

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? _label.Password
		: "";

	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
		=> passwordTb.PasswordChar = !showPasswdCB.Checked
		? _label.PasswordSym
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
			var form = _serviceProvider.GetRequiredService<CandidateLoggedInForm>();
			this.Hide();
			form.FormClosed += (s, args) => this.Close();
			form.Show();
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
