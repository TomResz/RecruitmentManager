using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateLoadingData;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.FileHandling;

namespace RecruitmentManager.Forms.Candidate;

public partial class CandidateLoggedInForm : Form
{
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IPictureBoxSetter _pictureBoxSetter;
	private readonly IMediator _mediator;

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
		profilePicturePB.MouseHover += (
			s,
			args) => toolTip1.Show(FullName, profilePicturePB);
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
	private async void edytujDaneToolStripMenuItem_Click(object sender, EventArgs e) => await EditData();

	private async Task EditData()
	{
		var form = _serviceProvider.GetRequiredService<EditCandidateData>();
		form.ShowDialog();
		await LoadControls();
	}

}