using MediatR;
using RecruitmentManager.Application.Functions.Common.Queries;
using RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.NotActive;
using RecruitmentManager.Application.Interfaces.Context;
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
		this.Load += FirstLoad;
	}

	private async void FirstLoad(
		object? sender,
		EventArgs e)
		=> await ReloadPage();

	private async Task ReloadPage()
	{
		var query = new GetPageOfNotActiveJobOffersQuery(Page, PageSize);
		_jobOfferList = await _mediator.Send(query);
		if (_jobOfferList.Items.Count is 0)
		{
			jobOffersDGV.Visible = false;
			pageCounterLabel.Text = "1/1";
			return;
		}
		jobOffersDGV.Fill(_jobOfferList.Items, row => new object[]
		{
			row.Id,
			row.Title,
			row.CreatedDate.ToString("HH:mm dd/MM/yyyy"),
			row.EndDate.ToString("HH:mm dd/MM/yyyy")
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