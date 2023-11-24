using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Events;
using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Forms.Recruiter.Assessment;

public partial class RateCandidateForm : Form
{
	private readonly IAssessmentCandidate _assessmentCandidate;
	private readonly IMediator _mediator;
	public RateCandidateForm(IAssessmentCandidate assessmentCandidate, IMediator mediator)
	{
		_assessmentCandidate = assessmentCandidate;
		_mediator = mediator;
		InitializeComponent();
		ActivePictureBoxes();
	}

	private void ActivePictureBoxes()
	{
		var tip = new ToolTip();
		notesPB.MouseHover += (s, args) => tip.Show("Notatki", notesPB);
		ratePB.MouseHover += (s, args) => tip.Show("Ocena", ratePB);
	}

	private async void rateBtn_Click(object sender, EventArgs e)
	{
		try
		{
			await _mediator.Publish(new RateCandidateEvent(
				_assessmentCandidate.JobApplicationId, 
				_assessmentCandidate.CandidateId,
				(int)rateNumericUpAndDown.Value,
				hasResignedCB.Checked, noteTb.Text));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}
}