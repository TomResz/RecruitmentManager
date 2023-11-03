using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Common.Queries;
using RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.Active;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class CurrentJobOffersView : UserControl
{
	private readonly IMediator _mediator;
	private readonly IWorkerSessionContext _workerSessionContext;
	private readonly IServiceProvider _serviceProvider;	
	private int Page = 1;
	private const int PageSize =15;

	private PagedList<JobOffersViewDto> _jobOfferList;

	public CurrentJobOffersView(
		IMediator mediator,
		IWorkerSessionContext workerSessionContext,
		IServiceProvider serviceProvider)
	{
		_mediator = mediator;
		_workerSessionContext = workerSessionContext;
		_serviceProvider = serviceProvider;
		InitializeComponent();
		jobOffersDGV.ApplyJobOfferSettings();
		jobOffersDGV.SizeChanged += (s, args) => jobOffersDGV.ApplyJobOfferSettings();
		this.Load += LoadPage;
	}

	private async void LoadPage(object? sender, EventArgs e) => await ReloadPage();

	private async Task ReloadPage()
	{
		var query = new GetPageOfCurrentJobOffersQuery(Page, PageSize);
		_jobOfferList = await _mediator.Send(query);
		if (_jobOfferList.Items.Count is 0)
		{
			jobOffersDGV.Visible = false;
			pageCounterLabel.Text = "1/1";
			return;
		}
		jobOffersDGV.Fill(_jobOfferList.Items,row => new object[]
		{
			row.Id,
			row.Title,
			row.CreatedDate.ToString("HH:mm dd/MM/yyyy"),
			row.EndDate.ToString("HH:mm dd/MM/yyyy")
		});
		jobOffersDGV.ApplyJobOfferSettings();
		pageCounterLabel.SetPageCounter(_jobOfferList);
	}

	private async void previousPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOfferList.HasPreviousPage)
		{
			--Page;
			await ReloadPage();
		}
	}

	private async void nextPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOfferList.HasNextPage)
		{
			Page++;
			await ReloadPage();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{

	}

	private void editBtn_Click(object sender, EventArgs e)
	{

	}

	private async void addBtn_Click(object sender, EventArgs e)
	{
		var addForm = _serviceProvider.GetRequiredService<AddJobOfferForm>();
		addForm.ShowDialog();
		await ReloadPage();
	}

}