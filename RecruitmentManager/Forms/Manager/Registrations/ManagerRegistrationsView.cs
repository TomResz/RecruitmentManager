using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Common.Queries.GetPageOfJobOffers.NotActive;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries.GetInterviewData;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetCandidatesForOffer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Forms.Common_employees;

namespace RecruitmentManager.Forms.Manager.Registrations;

public partial class ManagerRegistrationsView : UserControl
{
	private const int PageSize = 15;
	private int Page = 1;
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateContext _candidateContext;
	private PagedList<JobOffersViewDto> _jobs;

	public ManagerRegistrationsView(
		IMediator mediator,
		ICandidateContext candidateContext,
		IServiceProvider serviceProvider)
	{
		_mediator = mediator;
		_candidateContext = candidateContext;
		_serviceProvider = serviceProvider;
		InitializeComponent();
		AddActions();
		UserViewChangeSize();
		JobOffersChangeSize();
		usersView.Visible = false;
	}

	private void AddActions()
	{
		this.Load += ManagerRegistrationsView_Load;
		jobOffersDGV.CellClick += JobOffersDGV_CellClick;
		jobOffersDGV.SizeChanged += (s, args) => JobOffersChangeSize();
		usersView.SizeChanged += (s, args) => UserViewChangeSize();
		usersView.CellContentClick += UsersView_CellContentClick;
	}

	private void UserViewChangeSize()
	{
		usersView.Columns[1].Width = (int)(usersView.Width * 0.30);
		usersView.Columns[2].Width = (int)(usersView.Width * 0.30);
		usersView.Columns[3].Width = (int)(usersView.Width * 0.20);
		usersView.Columns[4].Width = (int)(usersView.Width * 0.20);
	}
	private void JobOffersChangeSize()
	{
		jobOffersDGV.Columns[1].Width = (int)(jobOffersDGV.Width * 0.4);
		jobOffersDGV.Columns[2].Width = (int)(jobOffersDGV.Width * 0.3);
		jobOffersDGV.Columns[3].Width = (int)(jobOffersDGV.Width * 0.3);
	}


	private async void UsersView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (usersView.CurrentRow is null || jobOffersDGV.CurrentRow is null ||
			!Guid.TryParse(usersView.CurrentRow.Cells[0].Value.ToString(), out var candidateId) ||
			!Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(), out var jobOfferId))
			return;
		if (e is { RowIndex: >= 0, ColumnIndex: 3 })
		{
			try
			{
				_candidateContext.SetId(candidateId);
				var form = _serviceProvider.GetRequiredService<ShowFullCandidateDataForm>();
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			finally
			{
				_candidateContext.Logout();
			}
		}
		else if (e is { RowIndex: >= 0, ColumnIndex: 4 })
		{
			if (usersView.CurrentRow.Cells[2].Value.ToString() == "Tak")
				return;


			var confirmation = MessageBox.Show("Czy chcesz zakwalifikować tego kandydata do rozmowy kwalifikacyjnej?",
				"Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirmation == DialogResult.No)
				return;

			try
			{
				var command = new QualifyToInterviewEvent(candidateId, jobOfferId);
				await _mediator.Publish(command);
				await ReloadUsers(jobOfferId);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}

	private async void JobOffersDGV_CellClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (jobOffersDGV.CurrentRow is null ||
		    !Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(), out var Id))
			return;
		try
		{
			await ReloadUsers(Id);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}

	private async Task ReloadUsers(Guid Id)
	{
		var query = new GetCandidatesForOfferQuery(Id);
		var response = await _mediator.Send(query);
		FillUserDgv(response);
	}

	private void FillUserDgv(List<CandidateDTO> response)
	{
		usersView.Visible = response.Count is not 0;
		usersView.Fill(response, item => new object[]
		{
			item.Id,
			item.FirstName + " " + item.LastName,
			item.IsQualificated ? "Tak" : "Nie"

		});
		usersView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		usersView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private async void ManagerRegistrationsView_Load(object? sender, EventArgs e) => await ReloadPage();

	private async Task ReloadPage()
	{
		var query = new GetPageOfNotActiveJobOffersQuery(Page, PageSize);
		_jobs = await _mediator.Send(query);
		jobOffersDGV.Visible = _jobs.Items.Count is not 0;
		jobOffersDGV.Fill(_jobs.Items, item => new object[]
		{
			item.Id,
			item.Title,
			item.CreatedDate.ToString("HH:mm dd/MM/yyyy"),
			item.EndDate.ToString("HH:mm dd/MM/yyyy")
		});
		pageCounterLabel.SetPageCounter(_jobs);
		jobOffersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		jobOffersDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private async void previousPageButton_Click(object sender, EventArgs e)
	{
		if (_jobs.HasPreviousPage)
		{
			--Page;
			await ReloadPage();
		}
	}

	private async void nextPageButton_Click(object sender, EventArgs e)
	{
		if (_jobs.HasNextPage)
		{
			++Page;
			await ReloadPage();
		}
	}
}