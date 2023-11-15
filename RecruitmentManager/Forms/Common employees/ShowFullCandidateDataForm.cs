using MediatR;
using RecruitmentManager.Application.Functions.Common.Queries.GetCandidateDataQuery;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Domain.Enums;
using RecruitmentManager.FileHandling;

namespace RecruitmentManager.Forms.Common_employees;

public partial class ShowFullCandidateDataForm : Form
{
	private readonly IMediator _mediator;
	private readonly IPictureBoxSetter _pictureBoxSetter;
	public ShowFullCandidateDataForm(IMediator mediator,
		IPictureBoxSetter pictureBoxSetter)
	{
		_mediator = mediator;
		_pictureBoxSetter = pictureBoxSetter;
		InitializeComponent();
		this.Load += ShowFullCandidateDataForm_Load;
	}

	private async void ShowFullCandidateDataForm_Load(object? sender, EventArgs e)
	{
		var query = new GetCandidateDataQuery(Guid.NewGuid());
		var response = await _mediator.Send(query);
		LoadProfileData(response.Data);
		LoadExperience(response.Experiences);
		LoadEducation(response.Educations);
		LoadHobbies(response.Hobbies);
		LoadSkills(response.Skills);
		LoadLanguages(response.KnowledgeOfLanguages);
	}

	private void LoadProfileData(CandidateBasicDataDTO candidateData)
	{
		nameTextBox.Text = candidateData.FirstName + " " + candidateData.LastName;
		emailTextBox.Text = candidateData.Email;
		phoneNumberTextBox.Text = candidateData.PhoneNumber;
		birthDatePB.Text = candidateData.DateOfBirth.HasValue
				? candidateData.DateOfBirth.Value.ToString("dd-MM-yyyy") : string.Empty;
		cityTextBox.Text = candidateData.City;
		_pictureBoxSetter.Set(candidateData.Picture, profilePicturePB);
	}

	private void LoadExperience(List<ExperienceDTO> responseExperiences)
	{
		experienceDGV.Fill(responseExperiences, item => new object[]
		{
			item.Id,
			item.JobName,
			item.CompanyName,
			item.Description ?? string.Empty,
			item.StartDateOfWork.ToString("MMMM yyyy"),
			item.OfCompletionOfWork.HasValue
				? item.OfCompletionOfWork.Value.ToString("MMMM yyyy") : "Do tej pory"
		});
		experienceDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		experienceDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private readonly Func<int,string> _getTypeOfEducation = levelOfEducation =>
		levelOfEducation switch
		{
			1 => "Podstawowe",
			2 => "Średnie",
			_ => "Wyższe"
		};

	private void LoadEducation(List<EducationDTO> responseEducations)
	{
		educationDGV.Fill(responseEducations, item => new object[]
		{
			item.Id,
			item.SchoolName,
			_getTypeOfEducation(item.LevelOfEducationId),
			item.Major ?? string.Empty,
			item.StartDate.ToString("MMMM yyyy"),
			item.DateOfCompletion.HasValue ? item.DateOfCompletion.Value.ToString("MMMM yyyy") : "Do tej pory",
		});
		educationDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		educationDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private void LoadHobbies(List<HobbyDTO> hobby)
	{
		hobbiesDGV.Fill(hobby, item => new object[]
		{
			item.Id,
			item.Description
		});
		hobbiesDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		hobbiesDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private void LoadSkills(List<SkillDTO> responseSkills)
	{
		skillsDGV.Fill(responseSkills, item => new object[]
		{
			item.Id,
			item.Description
		});
		skillsDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		skillsDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private void LoadLanguages(List<KnowledgeOfLanguageDTO> languages)
	{
		Func<int, string> getLevel = level => level switch
		{
			(int)LanguageLevel.A1 => "A1",
			(int)LanguageLevel.A2 => "A2",
			(int)LanguageLevel.B1 => "B1",
			(int)LanguageLevel.B2 => "B2",
			(int)LanguageLevel.C1 => "C1",
			_ => "C2",
		};
		languageDGV.Fill(languages,item=> new object[]
		{
			item.Id,
			item.Language,
			getLevel(item.LanguageProficiencyLevelId)
		});
		languageDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		languageDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}


}