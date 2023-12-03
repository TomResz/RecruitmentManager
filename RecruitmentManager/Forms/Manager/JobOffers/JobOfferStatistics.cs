using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetStatisticsOfJobPosting;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class JobOfferStatistics : Form
{
	private readonly IMediator _mediator;
	public JobOfferStatistics(IMediator mediator)
	{
		InitializeComponent();
		_mediator = mediator;
	}
	public async Task LoadData(Guid jobPostingId)
	{
		var response = await _mediator.Send(
			 new GetStatisticsOfJobPostingQuery(jobPostingId));
		total.Text = response.TotalNumberOfApplications.ToString();
		resignationLabel.Text = response.TotalNumberOfResignation.ToString();
		qualificatedCandidates.Text = $"{response.TotalNumberOfQualified}/{response.TotalNumberOfApplications}";
		interviewHeld.Text = $"{response.TotalNumberOfInterviewsHeld}/{response.TotalNumberOfInterview}";
	}
}
