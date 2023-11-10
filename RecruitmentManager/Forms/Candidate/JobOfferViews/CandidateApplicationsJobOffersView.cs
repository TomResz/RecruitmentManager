using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingsWhereApply;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Forms.Common;

namespace RecruitmentManager.Forms.Candidate.JobOfferViews;

public partial class CandidateApplicationsJobOffersView : UserControl
{
	private readonly IMediator _mediator;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IJobOfferContext _jobOfferContext;
	private readonly IServiceProvider _serviceProvider;
	public CandidateApplicationsJobOffersView(IMediator mediator,
		ICandidateSessionContext candidateSessionContext, 
		IJobOfferContext jobOfferContext, 
		IServiceProvider serviceProvider)
	{
		_mediator = mediator;
		_candidateSessionContext = candidateSessionContext;
		_jobOfferContext = jobOfferContext;
		_serviceProvider = serviceProvider;
		InitializeComponent();
		this.Load += CandidateApplicationsJobOffersView_Load;
		jobOffersDGV.SizeChanged += (s, args) => ChangeSize();
		jobOffersDGV.CellContentClick += JobOffersDGV_CellContentClick;
		ChangeSize();
	}

	private void JobOffersDGV_CellContentClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (e is { RowIndex: >= 0, ColumnIndex: 4 })
		{
			if (jobOffersDGV.CurrentRow is null)
				return;
			if(Guid.TryParse(jobOffersDGV.CurrentRow.Cells[0].Value.ToString(),out var uid))
			{
				try
				{
					_jobOfferContext.SetId(uid);
					var form = _serviceProvider.GetRequiredService<ShowJobOfferDetailsForm>();
					form.ShowDialog();
				}
				finally
				{
					_jobOfferContext.Clear();
				}
			}
		}
	}

	private void ColorColumn()
	{
		for(int i=0; i < jobOffersDGV.Rows.Count;++i)
		{
			var cell = jobOffersDGV.Rows[i].Cells[2];

			if (cell.Value.ToString() == "Tak")
			{
				cell.Style.BackColor = Color.LawnGreen;
				cell.Style.SelectionBackColor= Color.Green;
			}
			else
			{
				cell.Style.BackColor= Color.Red;
				cell.Style.SelectionBackColor = Color.DarkRed;
			}

		}
	}


	private void ChangeSize()
	{
		jobOffersDGV.Columns[1].Width = (int)(jobOffersDGV.Width * 0.4);
		jobOffersDGV.Columns[2].Width = (int)(jobOffersDGV.Width * 0.2);
		jobOffersDGV.Columns[3].Width = (int)(jobOffersDGV.Width * 0.2);
		jobOffersDGV.Columns[4].Width = (int)(jobOffersDGV.Width * 0.2);
		jobOffersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		jobOffersDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}
	private async void CandidateApplicationsJobOffersView_Load(object? sender, EventArgs e)
	{
		Guid id = _candidateSessionContext.CandidateId ?? throw new Exception();
		var command = new GetJobPostingsWhereCandidateApplyCommand(id);
		var response = await _mediator.Send(command);
		jobOffersDGV.Fill(response,item => new object[]
		{
			item.Id,
			item.Title,
			item.InterviewQualified ? "Tak" : "Nie",
			item.AddedDate.ToString("hh:mm  dd/MM/yyyy")
		});
		ColorColumn();
	}

}