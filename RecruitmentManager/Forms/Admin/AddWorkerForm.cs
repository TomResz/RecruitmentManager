using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.CreateWorker;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Forms.Admin;

public partial class AddWorkerForm : Form
{

	private const string Email = "E-Mail";
	private const string FirstName = "Imię";
	private const string LastName = "Nazwisko";
	private const string Password = "Hasło";
	private const string ConfirmedPassword = "Powtórz hasło";

	private IMediator _mediator;

	public AddWorkerForm(IMediator mediator)
	{
		InitializeComponent();
		InitializeTextBoxesAndLabels();
		adminRb.Checked = true;
		_mediator = mediator;
	}

	private void InitializeTextBoxesAndLabels()
	{
		emailLabel.Text = Email;
		firstNameLabel.Text = FirstName;
		lastNameLabel.Text = LastName;
		passwordLabel.Text = Password;
		confirmedPasswdLabel.Text = ConfirmedPassword;
		confirmedPasswdTb.PasswordChar = '●';
		passwordTb.PasswordChar = '●';
	}

	private void confirmedPasswdTb_TextChanged(object sender, EventArgs e)
		=> confirmedPasswdLabel.Text = string.IsNullOrEmpty(confirmedPasswdTb.Text)
		? ConfirmedPassword : "";

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? Password : "";

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? Email : "";
	private void lastNameTb_TextChanged(object sender, EventArgs e)
		=> lastNameLabel.Text = string.IsNullOrEmpty(lastNameTb.Text)
		? LastName : "";

	private void firstNameTb_TextChanged(object sender, EventArgs e)
		=> firstNameLabel.Text = string.IsNullOrEmpty(firstNameTb.Text)
		? FirstName : "";

	private Roles GetRole()
	{
		if (adminRb.Checked)
			return Roles.Admin;
		else if (managerRb.Checked)
			return Roles.Manager;
		return Roles.Recruiter;
	}
	private void ClearFields()
	{
		firstNameTb.Clear();
		lastNameTb.Clear();
		emailTb.Clear();
		passwordTb.Clear();
		confirmedPasswdTb.Clear();
	}



	private void showPasswdCB_CheckedChanged(object sender, EventArgs e)
	{
		if (showPasswdCB.Checked)
		{
			passwordTb.PasswordChar = default;
			confirmedPasswdTb.PasswordChar = default;
		}
		else
		{
			confirmedPasswdTb.PasswordChar = '●';
			passwordTb.PasswordChar = '●';
		}
	}

	private async void registerBtn_Click(object sender, EventArgs e)
	{
		var command = new CreateWorkerCommand(
			Email: emailTb.Text,
			FirstName: firstNameTb.Text,
			LastName: lastNameTb.Text,
			Password: passwordTb.Text,
			ConfirmedPassword: confirmedPasswdTb.Text,
			RoleId: (int)GetRole());
		try
		{
			await _mediator.Send(command);
			ClearFields();
			MessageBox.Show("Dodano nowego pracownika!", "Dodawanie pracowników",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception ex)
		{
			MessageBox.Show(text: ex.Message,
			caption: "Nieprawidłowe dane!",
			  buttons: MessageBoxButtons.OK,
			  icon: MessageBoxIcon.Error);
		}

	}
}
