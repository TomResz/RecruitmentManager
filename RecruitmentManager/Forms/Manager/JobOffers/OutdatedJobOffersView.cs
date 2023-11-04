using MediatR;
using RecruitmentManager.Application.Functions.Common.Queries;
using RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.NotActive;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class OutdatedJobOffersView : UserControl
{
	private readonly IMediator _mediator;

	private int Page = 1;
	private const int PageSize = 15;
	private PagedList<JobOffersViewDto> _jobOfferList;

	public OutdatedJobOffersView(
		IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		jobOffersDGV.ApplyJobOfferSettings();
		jobOffersDGV.SizeChanged += (s, args) => jobOffersDGV.ApplyJobOfferSettings();
		this.Load += OutdatedJobOffersView_Load;
	}

	private async void OutdatedJobOffersView_Load(
		object? sender,
		EventArgs e)
		=> await ReloadPage();
	public async Task ReloadPage()
	{
		var query = new GetPageOfNotActiveJobOffersQuery(Page, PageSize);
		_jobOfferList = await _mediator.Send(query);


		if (jobOffersDGV.Rows.Count != 0)
		{
			jobOffersDGV.Rows.Clear();
			return;
		}
		jobOffersDGV.Fill(_jobOfferList.Items, item => new object[]
		{
			item.Id,
			item.Title,
			item.CreatedDate.ToString("HH:mm dd/MM/yyyy"),
			item.EndDate.ToString("HH:mm dd/MM/yyyy")
		});
		pageCounterLabel.SetPageCounter(_jobOfferList);
	}


	private async void nextPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOfferList.HasNextPage)
		{
			Page++;
			await ReloadPage();
		}
	}

	private async void previousPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOfferList.HasPreviousPage)
		{
			Page--;
			await ReloadPage();
		}
	}
}