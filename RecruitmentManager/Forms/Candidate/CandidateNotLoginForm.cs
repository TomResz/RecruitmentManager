using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetPageOfJobOffers;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Candidate;

public partial class CandidateNotLoginForm : Form
{
	private const int _pageSize = 10;
	private int _pageNumber = 1;

	private PagedList<JobOffersViewDto> _jobPagedList;


	private readonly IServiceProvider _serviceProvider;
	private readonly IMediator _mediator;
	public CandidateNotLoginForm(
		IServiceProvider serviceProvider,
		IMediator mediator)
	{
		_serviceProvider = serviceProvider;
		_mediator = mediator;
		InitializeComponent();
		ChangeSize();
		this.Load += LoadJobOffers;
	}

	private async void LoadJobOffers(object? sender, EventArgs e)
		=> await ReloadPage();

	private async Task ReloadPage()
	{
		_jobPagedList = await _mediator.Send(new GetPageOfJobOffersQuery(_pageNumber, _pageSize));
		if (_jobPagedList.Items.Count is 0)
		{
			jobOffersDGV.Visible = false;
			pageCounterLabel.Text = "1/1";
			return;
		}

		jobOffersDGV.Fill(_jobPagedList.Items,
			item => new object[]
			{
				item.Id,
				item.Title,
				item.CreatedDate.ToShortDateString(),
				item.EndDate.ToShortDateString()
			});
		pageCounterLabel.SetPageCounter(_jobPagedList);
	}

	private async void previousPagePB_Click(object sender, EventArgs e)
	{
		if (_jobPagedList.HasPreviousPage)
		{
			_pageNumber++;
			await ReloadPage();
		}
	}

	private async void nextPagePB_Click(object sender, EventArgs e)
	{
		if (_jobPagedList.HasNextPage)
		{
			_pageNumber--;
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

	private void jobOffersDGV_SizeChanged(object sender, EventArgs e) => ChangeSize();

	private void ChangeSize()
	{
		jobOffersDGV.Columns[1].Width = (int)(jobOffersDGV.Width * 0.5);
		jobOffersDGV.Columns[2].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.Columns[3].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.Columns[4].Width = (int)(jobOffersDGV.Width * 0.2);
		jobOffersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		jobOffersDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		jobOffersDGV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		jobOffersDGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		jobOffersDGV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		jobOffersDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
	}
}
