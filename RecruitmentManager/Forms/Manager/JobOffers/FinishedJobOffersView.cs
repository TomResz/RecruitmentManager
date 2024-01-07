using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.CreatePDFReport;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetPageOfCompletedJobOffers;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class FinishedJobOffersView : UserControl
{
	private const int _pageSize = 10;
	private int _pageIndex = 1;
	private readonly IMediator _mediator;
	private PagedList<JobOffersViewDto> _jobOfferList;
	private readonly IServiceProvider _serviceProvider;
	public FinishedJobOffersView(IMediator mediator, IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_mediator = mediator;
		this.Load += FinishedJobOffersView_Load;
		jobOffersDGV.CellClick += JobOffersDGV_CellClick;
		jobOffersDGV.SizeChanged += (s, args) => ChangeSize();
		_serviceProvider = serviceProvider;
	}

	private async void JobOffersDGV_CellClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (e is { ColumnIndex: 4, RowIndex: >= 0 })
		{
			if(jobOffersDGV.CurrentRow is not null &&
				Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(),out var Id))
			{
				var form = _serviceProvider.GetRequiredService<CandidateListForm>();
				await form.Load(Id);
				form.ShowDialog();
			}
		}
		else if( e is { ColumnIndex: 5, RowIndex: >=0 })
		{
			if (jobOffersDGV.CurrentRow is not null &&
				Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(), out var Id))
			{
				var fileName = $"raport_{DateTime.Now.ToString("dd-MM-yyyy")}.pdf";

				var folderBrowser = new FolderBrowserDialog();
				var result = folderBrowser.ShowDialog();
				if(result == DialogResult.OK)
				{
					string filePath = folderBrowser.SelectedPath + "\\" + fileName;
					var @event = new CreatePDFEvent(Id,filePath);
					await _mediator.Send(@event);
				}
			}
		}
	}

	private async void FinishedJobOffersView_Load(object? sender, EventArgs e) => await ReloadPage();

	private async Task ReloadPage()
	{
		var query = new GetPageOfCompletedJobOffersQuery(_pageIndex, _pageSize);
		_jobOfferList = await _mediator.Send(query);
		if (_jobOfferList.Items.Count is 0)
		{
			jobOffersDGV.Visible = false;
			pageCounterLabel.Text = "1/1";
			return;
		}

		jobOffersDGV.Visible = _jobOfferList.Items.Count is not 0;
		jobOffersDGV.Fill(_jobOfferList.Items, row => new object[]
		{
			row.Id,
			row.Title,
			row.CreatedDate.ToString("HH:mm dd/MM/yyyy"),
			row.EndDate.ToString("HH:mm dd/MM/yyyy")
		});
		ChangeSize();
		pageCounterLabel.SetPageCounter(_jobOfferList);
	}

	private void ChangeSize()
	{
		jobOffersDGV.Columns[1].Width = (int)(jobOffersDGV.Width * 0.3);
		jobOffersDGV.Columns[2].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.Columns[3].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.Columns[4].Width = (int)(jobOffersDGV.Width * 0.2);
		jobOffersDGV.Columns[5].Width = (int)(jobOffersDGV.Width * 0.2);
		jobOffersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		jobOffersDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private async void previousPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOfferList.HasPreviousPage)
		{
			--_pageIndex;
			await ReloadPage();
		}
	}

	private async void nextPageButton_Click(object sender, EventArgs e)
	{
		if (_jobOfferList.HasNextPage)
		{
			++_pageIndex;
			await ReloadPage();
		}
	}
}
