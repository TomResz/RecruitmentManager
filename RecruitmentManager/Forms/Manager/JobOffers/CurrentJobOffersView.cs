using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Common.Queries;
using RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.Active;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CompleteJobOffer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Forms.Common;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class CurrentJobOffersView : UserControl
{
	private readonly IMediator _mediator;
	private readonly IWorkerSessionContext _workerSessionContext;
	private readonly IServiceProvider _serviceProvider;
	private readonly IJobOfferContext _jobOfferContext;
	private int Page = 1;
	private const int PageSize = 15;

	private PagedList<JobOffersViewDto> _jobOfferList;

	public CurrentJobOffersView(
		IMediator mediator,
		IWorkerSessionContext workerSessionContext,
		IServiceProvider serviceProvider,
		IJobOfferContext jobOfferContext)
	{
		_mediator = mediator;
		_workerSessionContext = workerSessionContext;
		_serviceProvider = serviceProvider;
		_jobOfferContext = jobOfferContext;
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
		jobOffersDGV.Fill(_jobOfferList.Items, row => new object[]
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

	private void editBtn_Click(object sender, EventArgs e)
	{
		if (jobOffersDGV.CurrentRow is null)
			return;

		if (Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(), out Guid uid))
		{
			try
			{
				_jobOfferContext.SetId(uid);
				var form = _serviceProvider.GetRequiredService<EditJobOfferForm>();
				form.ShowDialog();
			}
			finally
			{
				_jobOfferContext.Clear();
			}
		}
	}

	private async void addBtn_Click(object sender, EventArgs e)
	{
		var addForm = _serviceProvider.GetRequiredService<AddJobOfferForm>();
		addForm.ShowDialog();
		await ReloadPage();
	}

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

	private async void endBtn_Click(object sender, EventArgs e)
	{
		if (jobOffersDGV.CurrentRow is null)
			return;

		var response = MessageBox.Show("Czy napewno zakończyć tą ofertę pracy?",
			"Zakończenie oferty pracy",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (response == DialogResult.No)
			return;


		if (Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(), out Guid uid))
		{
			try
			{
				var command = new CompleteJobOfferCommand(uid);
				await _mediator.Send(command);

				MessageBox.Show("Pomyślnie zakończono ofertę pracy!",
					"Zakończenie oferty pracy.", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				await ReloadPage();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Błąd!",
					MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}