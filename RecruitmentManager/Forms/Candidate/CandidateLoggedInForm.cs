using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateLoadingData;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.FileHandling;
using RecruitmentManager.Forms.Candidate.DataDictionary;
using RecruitmentManager.Forms.Candidate.Interviews;
using RecruitmentManager.Forms.Candidate.JobOfferViews;
using RecruitmentManager.Forms.Candidate.News;

namespace RecruitmentManager.Forms.Candidate;

public partial class CandidateLoggedInForm : Form
{
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IPictureBoxSetter _pictureBoxSetter;
	private readonly IMediator _mediator;
	private UserControl _currentControl;
	private string FullName;

	public CandidateLoggedInForm(
		IServiceProvider serviceProvider,
		ICandidateSessionContext candidateSessionContext,
		IMediator mediator,
		IPictureBoxSetter pictureBoxSetter)
	{
		_serviceProvider = serviceProvider;
		_candidateSessionContext = candidateSessionContext;
		_mediator = mediator;
		_pictureBoxSetter = pictureBoxSetter;
		InitializeComponent();
		this.Load += CandidateLoggedInForm_Load;
		var initForm = _serviceProvider.GetRequiredService<NewsView>();
		ShowControl(initForm);
		profilePicturePB.MouseHover += (s, args) => toolTip1.Show(FullName, profilePicturePB);
	}

	private async void CandidateLoggedInForm_Load(object? sender, EventArgs e)
		=> await LoadControls();

	private async Task LoadControls()
	{
		Guid id = _candidateSessionContext.CandidateId ?? throw new InvalidDataException();
		var query = new GetCandidateLoadingDataQuery(id);
		var response = await _mediator.Send(query);
		FullName = response.FullName;
		if (response.Picture is not null)
		{
			_pictureBoxSetter.Set(response.Picture, profilePicturePB);
		}
	}

	private void logoutBtn_Click_1(object sender, EventArgs e)
	{
		var confirmation = MessageBox.Show("Czy napewno chcesz się wylogować?",
			"Wylogywanie się", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.Yes)
		{
			_candidateSessionContext.Logout();
			this.Hide();
			var candidateLogin = _serviceProvider.GetRequiredService<LoginCandidateForm>();
			candidateLogin.FormClosed += (s, args) => this.Close();
			candidateLogin.Show();
		}
	}

	private async void profilePicture_Click(object sender, EventArgs e) => await EditData();


	private async Task EditData()
	{
		var form = _serviceProvider.GetRequiredService<EditCandidateData>();
		form.ShowDialog();
		await LoadControls();
	}
	public void ShowControl(UserControl controlToShow)
	{
		if (_currentControl != controlToShow)
		{
			if (_currentControl != null)
				_currentControl.Visible = false;
			if (!mainLayout.Controls.Contains(controlToShow))
			{
				controlToShow.Dock = DockStyle.Fill;
				mainLayout.Controls.Add(controlToShow, 1, 0);
			}
			controlToShow.Visible = true;
			_currentControl = controlToShow;
		}
	}

	private void newsBtn_Click(object sender, EventArgs e)
		=> ShowControl(_serviceProvider.GetRequiredService<NewsView>());

	private void editDataBtn_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<CandidateDataDictionaryView>();
		ShowControl(uc);
	}

	private void interviewBtn_Click(object sender, EventArgs e)
	{
		ShowControl(_serviceProvider.GetRequiredService<CandidateInterviewMainView>());
	}

	private void jobOfferBtn_Click(object sender, EventArgs e)
	{
		var view = _serviceProvider.GetRequiredService<CandidateJobOfferMainView>();
		ShowControl(view);
	}

	private void toolStripMenuItem2_Click(object sender, EventArgs e)
	{
		var uc = _serviceProvider.GetRequiredService<CandidateDataDictionaryView>();
		ShowControl(uc);
	}

	private async void toolStripMenuItem1_Click(object sender, EventArgs e)
		=> await EditData();
}