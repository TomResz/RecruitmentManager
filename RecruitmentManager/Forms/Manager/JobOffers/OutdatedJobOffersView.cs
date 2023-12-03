using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.NotActive;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CompleteRecruitmentProcess;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class OutdatedJobOffersView : UserControl
{
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private int Page = 1;
	private const int PageSize = 15;
	private PagedList<JobOffersViewDto> _jobOfferList;

	public OutdatedJobOffersView(
		IMediator mediator, IServiceProvider serviceProvider)
	{
		_mediator = mediator;
		InitializeComponent();
		jobOffersDGV.Visible = false;
		jobOffersDGV.ApplyJobOfferSettings();
		jobOffersDGV.SizeChanged += (s, args) => jobOffersDGV.ApplyJobOfferSettings();
		this.Load += OutdatedJobOffersView_Load;
		_serviceProvider = serviceProvider;
	}

	private async void OutdatedJobOffersView_Load(
		object? sender,
		EventArgs e)
		=> await ReloadPage();
	public async Task ReloadPage()
	{
		var query = new GetPageOfNotActiveJobOffersQuery(Page, PageSize);
		_jobOfferList = await _mediator.Send(query);

		jobOffersDGV.Visible = _jobOfferList.Items.Count is not 0;
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

	private async void button1_Click(object sender, EventArgs e)
	{

		if (jobOffersDGV.CurrentRow is null ||
			!Guid.TryParse(jobOffersDGV.CurrentRow?.Cells[0].Value.ToString(), out var Id))
		{
			return;
		}
		var confirmationBox = MessageBox.Show("Czy napewno zakończyć ten proces rekrutacyjny?",
			"Proces rekrutacyjny",
	MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmationBox == DialogResult.No) { return; }

		await _mediator.Send(new CompleteRecruitmentProcessCommand(Id));
		await ReloadPage();
	}

	private async void jobOffersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e is not { RowIndex: >= 0, ColumnIndex: 4 })
			return;
		if (jobOffersDGV.CurrentRow is null ||
			!Guid.TryParse(jobOffersDGV.CurrentRow?.Cells[0].Value.ToString(), out var Id))
		{
			return;
		}
		var form = _serviceProvider.GetRequiredService<JobOfferStatistics>();
		await form.LoadData(Id);
		form.ShowDialog();
	}
}