using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.CreateWorker;
using RecruitmentManager.Domain.Enums;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager.Forms.Admin;

public partial class AddWorkerForm : Form
{
	private readonly IMediator _mediator;
	private readonly ISubtitles _label;
	public AddWorkerForm(IMediator mediator, ISubtitles labels)
	{
		InitializeComponent();
		InitializeTextBoxesAndLabels();
		adminRb.Checked = true;
		_mediator = mediator;
		_label = labels;
	}

	private void InitializeTextBoxesAndLabels()
	{
		emailLabel.Text = _label.Email;
		firstNameLabel.Text = _label.FirstName;
		lastNameLabel.Text = _label.LastName;
		passwordLabel.Text = _label.Password;
		confirmedPasswdLabel.Text = _label.RepeatNewPassword;
		confirmedPasswdTb.PasswordChar = _label.PasswordSym;
		passwordTb.PasswordChar = _label.PasswordSym;
	}

	private void confirmedPasswdTb_TextChanged(object sender, EventArgs e)
		=> confirmedPasswdLabel.Text = string.IsNullOrEmpty(confirmedPasswdTb.Text)
		? _label.RepeatPassword : "";

	private void passwordTb_TextChanged(object sender, EventArgs e)
		=> passwordLabel.Text = string.IsNullOrEmpty(passwordTb.Text)
		? _label.Password : "";

	private void emailTb_TextChanged(object sender, EventArgs e)
		=> emailLabel.Text = string.IsNullOrEmpty(emailTb.Text)
		? _label.Email : "";
	private void lastNameTb_TextChanged(object sender, EventArgs e)
		=> lastNameLabel.Text = string.IsNullOrEmpty(lastNameTb.Text)
		? _label.LastName : "";

	private void firstNameTb_TextChanged(object sender, EventArgs e)
		=> firstNameLabel.Text = string.IsNullOrEmpty(firstNameTb.Text)
		? _label.FirstName : "";

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
