using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Worker_Functions.Login;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Forms;

public partial class LoginWorkerForm : Form
{

	private readonly IMediator _mediator;
	private readonly IWorkerSessionContext _workerSession;

	private const string Password = "Hasło";
	private const string Email = "E-Mail";
	private const char PasswordChar = '●';

	private readonly IServiceProvider _serviceProvider;
	public LoginWorkerForm(
		IServiceProvider serviceProvider,
		IMediator mediator,
		IWorkerSessionContext workerSession)
	{
		InitializeComponent();
		InitializeTextboxesLabels();
		_serviceProvider = serviceProvider;
		_mediator = mediator;
		_workerSession = workerSession;
	}

	private void InitializeTextboxesLabels()
	{
		passwordLabel.Text = Password;
		emailLabel.Text = Email;
		passwordTb.PasswordChar = PasswordChar;
	}

	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
	{
		if (!showPasswdCB.Checked)
		{
			passwordTb.PasswordChar = PasswordChar;
			return;
		}
		passwordTb.PasswordChar = default;
	}

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? Email : "";

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? Password : "";

	private async void loginBtn_ClickAsync(object sender, EventArgs e)
	{
		var loginRequest = new LoginWorkerCommand(
			Email: emailTb.Text, 
			Password: passwordTb.Text);
		try
		{
			var response = await _mediator.Send(loginRequest);	
			_workerSession.SetId(response.Id);
			_workerSession.SetRole(response.Role);
			switch(response.Role)	
			{
				case Roles.Admin:
					OpenAdminForm();
					break;
				default:
					break;
			}
		}
		catch(Exception ex) 
		{
			MessageBox.Show(text: ex.Message,
						caption: "Logowanie się nie powiodło!",
						  buttons: MessageBoxButtons.OK,
						  icon: MessageBoxIcon.Error);
		}
	}

	private void OpenAdminForm()
	{
		var admin = _serviceProvider.GetRequiredService<AdminForm>();
		this.Hide();
		admin.Closed += (s, args) => this.Close();
		admin.Show();
	}

	private void backToMainFormLabel_Click(object sender, EventArgs e)
	{
		this.Hide();
		var mainForm = _serviceProvider.GetRequiredService<MainForm>();
		mainForm.FormClosed += (s, args) => this.Close();
		mainForm.Show();
	}
}
