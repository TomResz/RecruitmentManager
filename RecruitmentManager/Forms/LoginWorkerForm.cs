using Microsoft.Extensions.DependencyInjection;

namespace RecruitmentManager.Forms;

public partial class LoginWorkerForm : Form
{
	private const string Password = "Hasło";
	private const string Email = "E-Mail";
	private const char PasswordChar = '●';

	private readonly IServiceProvider _serviceProvider;
	public LoginWorkerForm(IServiceProvider serviceProvider)
	{
		InitializeComponent();
		InitializeTextboxesLabels();
		_serviceProvider = serviceProvider;
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

	private void loginBtn_Click(object sender, EventArgs e)
	{
		OpenAdminForm();
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
