using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ApplyForJobPosting;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingsWhereApply;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingWhereDidNotApply;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Forms.Common;

namespace RecruitmentManager.Forms.Candidate.JobOfferViews;

public partial class CandidatePossibleJobOffersView : UserControl
{
	private readonly IMediator _mediator;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IJobOfferContext _jobOfferContext;
	private readonly IServiceProvider _serviceProvider;
	private List<JobOffersViewDto> _jobs;
	public CandidatePossibleJobOffersView(
		IMediator mediator,
		ICandidateSessionContext candidateSessionContext,
		IJobOfferContext jobOfferContext,
		IServiceProvider serviceProvider)
	{
		_mediator = mediator;
		_candidateSessionContext = candidateSessionContext;
		_jobOfferContext = jobOfferContext;
		_serviceProvider = serviceProvider;
		InitializeComponent();
		this.Load += LoadDGV;
		ChangeSize();
		jobOffersDGV.SizeChanged += JobOffersDGV_SizeChanged;
	}

	private void ChangeSize()
	{
		jobOffersDGV.Columns[1].Width = (int)(jobOffersDGV.Width * 0.4);
		jobOffersDGV.Columns[2].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.Columns[3].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.Columns[4].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.Columns[5].Width = (int)(jobOffersDGV.Width * 0.15);
		jobOffersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		jobOffersDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private void JobOffersDGV_SizeChanged(
		object? sender,
		EventArgs e)
		=> ChangeSize();

	private async void LoadDGV(
		object? sender,
		EventArgs e) => await ReloadPage();


	private async Task ReloadPage()
	{
		Guid id = _candidateSessionContext.CandidateId ?? throw new Exception();
		var query = new GetActiveJobPostingWhereDidNotApplyCommand(id);
		_jobs = await _mediator.Send(query);
		jobOffersDGV.Fill(_jobs, item => new object[]
		{
			item.Id,
			item.Title,
			item.CreatedDate.ToString("HH:mm   dd/MM/yyyy"),
			item.EndDate.ToString("HH:mm   dd/MM/yyyy")
		});
	}

	private async void jobOffersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if(jobOffersDGV.CurrentRow is null)
			return;
		if (e is { ColumnIndex: 5, RowIndex: >= 0 })
		{
			var jobPostingId = Guid.Parse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString() ?? string.Empty);
			var candidateId = _candidateSessionContext.CandidateId ?? Guid.Empty;
			var confirmation = MessageBox.Show("Czy napewno chcesz aplikować na te stanowisko?",
				"Aplikacja do ofert pracy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirmation == DialogResult.No)
				return;
			await ApplyToJobOffer(jobPostingId, candidateId);
		}
		else if (e is {ColumnIndex: 4 , RowIndex: >= 0})
		{
			var jobPostingId = Guid.Parse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString() ?? string.Empty);
			OpenJobOfferDetailsView(jobPostingId);
		}
	}

	private async Task ApplyToJobOffer(
		Guid jobPostingId,
		Guid candidateId)
	{
		try
		{
			var command = new ApplyForJobPostingCommand(jobPostingId, candidateId);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie aplikowano do tej oferty pracy!", "Aplikacja",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally
		{
			await ReloadPage();
		}
	}

	private void OpenJobOfferDetailsView(
		Guid jobPostingId)
	{
		try
		{
			_jobOfferContext.SetId(jobPostingId);
			var jobOfferForm = _serviceProvider.GetRequiredService<ShowJobOfferDetailsForm>();
			jobOfferForm.ShowDialog();
		}
		finally
		{
			_jobOfferContext.Clear();
		}
	}

}