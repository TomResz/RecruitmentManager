using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.Active;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Forms.Common;

namespace RecruitmentManager.Forms.Candidate;

public partial class CandidateNotLoginForm : Form
{
	private const int _pageSize = 10;
	private int _pageNumber = 1;

	private PagedList<JobOffersViewDto> _jobPagedList;

	private readonly IJobOfferContext _jobOfferContext;
	private readonly IServiceProvider _serviceProvider;
	private readonly IMediator _mediator;
	public CandidateNotLoginForm(
		IServiceProvider serviceProvider,
		IMediator mediator,
		IJobOfferContext jobOfferContext)
	{
		_serviceProvider = serviceProvider;
		_mediator = mediator;
		_jobOfferContext = jobOfferContext;
		InitializeComponent();
		jobOffersDGV.Visible = false;
		jobOffersDGV.ApplyJobOfferSettings();
		this.Load += LoadJobOffers;
	}

	private async void LoadJobOffers(object? sender, EventArgs e)
		=> await ReloadPage();

	private async Task ReloadPage()
	{
		_jobPagedList = await _mediator.Send(new GetPageOfCurrentJobOffersQuery(_pageNumber, _pageSize));
		jobOffersDGV.Visible = _jobPagedList.Items.Count is not 0;
		if (_jobPagedList.Items.Count is 0)
		{
			pageCounterLabel.Text = "1/1";
			return;
		}
		jobOffersDGV.Fill(_jobPagedList.Items,
			item => new object[]
			{
				item.Id,
				item.Title,
				item.CreatedDate.ToString("HH:mm dd/MM/yyyy"),
				item.EndDate.ToString("HH:mm dd/MM/yyyy")
			});
		pageCounterLabel.SetPageCounter(_jobPagedList);
	}

	private async void previousPagePB_Click(object sender, EventArgs e)
	{
		if (_jobPagedList.HasPreviousPage)
		{
			_pageNumber--;
			await ReloadPage();
		}
	}

	private async void nextPagePB_Click(object sender, EventArgs e)
	{
		if (_jobPagedList.HasNextPage)
		{
			_pageNumber++;
			await ReloadPage();
		}
	}

	private void loginBtn_Click(object sender, EventArgs e)
	{
		this.Hide();
		var form = _serviceProvider.GetRequiredService<LoginCandidateForm>();
		form.FormClosed += (s, args) => this.Close();
		form.Show();
	}

	private void registerBtn_Click(object sender, EventArgs e)
	{
		this.Hide();
		var form = _serviceProvider.GetRequiredService<RegisterCandidateForm>();
		form.FormClosed += (s, args) => this.Close();
		form.Show();
	}

	private void jobOffersDGV_SizeChanged(object sender, EventArgs e) => jobOffersDGV.ApplyJobOfferSettings();

	private void jobOffersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e is not { RowIndex: >= 0, ColumnIndex: 4 }) return;
		try
		{
			if (jobOffersDGV.CurrentRow is not null &&
			    Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(), out Guid uid))
			{
				_jobOfferContext.SetId(uid);
				var form = _serviceProvider.GetRequiredService<ShowJobOfferDetailsForm>();
				form.ShowDialog();
			}
		}
		finally
		{
			_jobOfferContext.Clear();
		}
	}
}
