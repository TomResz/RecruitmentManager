using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfEvaluatedCandidates;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetPageOfEndedJobOffers;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.Registrations;

public partial class ManagerEndedRegistrationView : UserControl
{
	private const int _pageSize = 10;
	private int _currentPage = 1;

	private PagedList<JobOffersViewDto> _jobOffers;
	private readonly IMediator _mediator;

	public ManagerEndedRegistrationView(IMediator mediator)
	{
		InitializeComponent();
		this.Load += ManagerEndedRegistrationView_Load;
		jobOffersDGV.SizeChanged += (s, args) => JobOffersChangeSize();
		_mediator = mediator;
		usersView.Visible = false;
		jobOffersDGV.CellClick += JobOffersDGV_CellClick;
	}

	private async void JobOffersDGV_CellClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (jobOffersDGV.CurrentRow is not null &&
			Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(), out var id))
		{
			await LoadUsers(id);
		}
	}
	private async Task LoadUsers(Guid id)
	{
		var query = new GetListOfEvaluatedCandidatesQuery(id);
		var users = await _mediator.Send(query);
		usersView.Fill(users, x => new object[]
		{
			x.CandidateId,
			x.Position,
			x.FullName,
			x.AverageGrade
		});
		usersView.Visible = users.Count > 0;
		
	}
	private async void ManagerEndedRegistrationView_Load(object? sender, EventArgs e)
		=> await LoadPageOfJobOffers();

	private void JobOffersChangeSize()
	{
		jobOffersDGV.Columns[1].Width = (int)(jobOffersDGV.Width * 0.4);
		jobOffersDGV.Columns[2].Width = (int)(jobOffersDGV.Width * 0.3);
		jobOffersDGV.Columns[3].Width = (int)(jobOffersDGV.Width * 0.3);
		jobOffersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		jobOffersDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}
	private async Task LoadPageOfJobOffers()
	{
		_jobOffers = await _mediator.Send(
			   new GetPageOfEndedJobOffersQuery(_currentPage, _pageSize));
		jobOffersDGV.Fill(_jobOffers.Items, x => new object[]
		{
			x.Id,
			x.Title,
			x.CreatedDate.ToString("dd-MM-yyyy"),
			x.EndDate.ToString("dd-MM-yyyy")
		});
		JobOffersChangeSize();
		pageCounterLabel.Text = $"{_currentPage}/{_jobOffers.PageTotalCount}";
	}

	private async void nextPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOffers.HasNextPage)
		{
			++_currentPage;
			await LoadPageOfJobOffers();
		}
	}

	private async void previousPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOffers.HasPreviousPage)
		{
			--_currentPage;
			await LoadPageOfJobOffers();
		}
	}
}
