using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.UpdateData;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateDataToEdit;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.FileHandling;
using RecruitmentManager.Subtitles;

namespace RecruitmentManager.Forms.Candidate;

public partial class EditCandidateData : Form
{
	private readonly ICandidateSessionContext _sessionContext;
	private readonly IMediator _mediator;
	private readonly IProfilePictureGetter _profilePictureGetter;
	private readonly IPictureBoxSetter _pictureBoxSetter;
	private readonly ISubtitles _subtitles;
	private Guid Id;
	private byte[]? _profilePicture = null;


	public EditCandidateData(
		ICandidateSessionContext sessionContext,
		IMediator mediator,
		IProfilePictureGetter profilePictureGetter,
		ISubtitles subtitles,
		IPictureBoxSetter pictureBoxSetter)
	{
		_sessionContext = sessionContext;
		_mediator = mediator;
		_profilePictureGetter = profilePictureGetter;
		_subtitles = subtitles;
		_pictureBoxSetter = pictureBoxSetter;
		InitializeComponent();
		InitializeLabels();
		emailTb.ReadOnly = true;
		this.Load += EditCandidateData_Load;
		AddActionToPictureBoxes();

	}

	private void AddActionToPictureBoxes()
	{
		emailPB.MouseHover += (s, args) => toolTip1.Show(_subtitles.Email, emailPB);
		firstNamePb.MouseHover += (s, args) => toolTip1.Show(_subtitles.FirstName, firstNamePb);
		lastNamePB.MouseHover += (s, args) => toolTip1.Show(_subtitles.LastName, lastNamePB);
		birthDatePB.MouseHover += (s, args) => toolTip1.Show("Data urodzenia", birthDatePB);
		phoneNumberPB.MouseHover += (s, args) => toolTip1.Show(_subtitles.PhoneNumber, phoneNumberPB);
		cityPB.MouseHover += (s, args) => toolTip1.Show("Miejscowość zamieszkania", cityPB);
	}

	private async void EditCandidateData_Load(object? sender, EventArgs e)
	{
		Id = _sessionContext.CandidateId ?? throw new Exception();
		var query = new GetCandidateDataToEditQuery(Id);
		var response = await _mediator.Send(query);
		InitializeControls(response);
	}

	private void InitializeLabels()
	{
		firstNameLabel.Text = _subtitles.FirstName;
		lastNameLabel.Text = _subtitles.LastName;
		phoneNumberLabel.Text = _subtitles.PhoneNumber;
		cityLabel.Text = "Miejscowość zamieszkania";
	}
	private void InitializeControls(CandidateBasicDataDTO response)
	{
		firstNameTb.Text = response.FirstName;
		lastNameTb.Text = response.LastName;
		birthDatePicker.Value = response.DateOfBirth ?? DateTime.Now.AddYears(-16).AddDays(-1);
		emailTb.Text = response.Email;
		phoneNumberTb.Text = response.PhoneNumber;
		cityTb.Text = response.City;
		_profilePicture = response.Picture;
		if (response.Picture is not null)
		{
			_pictureBoxSetter.Set(response.Picture, profilePicturePB);
		}
	}

	private async void editDataBtn_Click(object sender, EventArgs e)
	{
		try
		{
			editDataBtn.Enabled = false;
			var command = new CandidateBasicDataDTO(
				Id,
				firstNameTb.Text,
				lastNameTb.Text,
				_profilePicture,
				phoneNumberTb.Text,
				emailTb.Text,
				cityTb.Text,
				birthDatePicker.Value.Date);

			await _mediator.Send(new UpdateCandidateDataCommand(command));
			MessageBox.Show("Pomyślnie edytowano dane!", "Edycja danych.",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
			await Task.Delay(500);
			this.Close();

		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
		finally
		{
			editDataBtn.Enabled = true;
		}
	}

	private void button1_Click(object sender, EventArgs e) => PickPicture();

	private void PickPicture()
	{
		_profilePicture = _profilePictureGetter.GetBytes();
		_pictureBoxSetter.Set(_profilePicture, profilePicturePB);
	}


	private void firstNameTb_TextChanged(object sender, EventArgs e)
		=> firstNameLabel.Text = string.IsNullOrEmpty(firstNameTb.Text)
			? _subtitles.FirstName
			: "";

	private void lastNameTb_TextChanged(object sender, EventArgs e)
		=> lastNameLabel.Text = string.IsNullOrEmpty(lastNameTb.Text)
			? _subtitles.LastName : "";

	private void phoneNumberTb_TextChanged(object sender, EventArgs e)
		=> phoneNumberLabel.Text = string.IsNullOrEmpty(phoneNumberTb.Text)
		? _subtitles.PhoneNumber : "";

	private void cityTb_TextChanged(object sender, EventArgs e)
		=> cityLabel.Text = string.IsNullOrEmpty(cityTb.Text)
		? "Miejscowość zamieszkania" : "";

	private void profilePicturePB_Click(object sender, EventArgs e) => PickPicture();
}