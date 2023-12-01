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
		noteTb.MouseHover += (s, args) => tip.Show("Tutaj należy można wpisać notatki", noteTb);
		notesPB.MouseHover += (s, args) => tip.Show("Notatki", notesPB);
		ratePB.MouseHover += (s, args) => tip.Show("Ocena", ratePB);
	}

	private DialogResult Confirmation() 
		=> MessageBox.Show("Czy napewno chcesz ocenić tego kandydata?", "Ocenianie",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);
	private bool ConfirmationOfResignation()
	{
		if(!hasResignedCB.Checked)
			return false;
		var result = MessageBox.Show("Czy napewno kandydat zrezygnował z dalszej rekrutacji ?",
		"Rezygnacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		return result == DialogResult.No;
	}
	private async void rateBtn_Click(object sender, EventArgs e)
	{
		if (DialogResult.No == Confirmation() ||
			 ConfirmationOfResignation())
			return;

		try
		{
			await _mediator.Publish(new RateCandidateEvent(
				_assessmentCandidate.JobApplicationId, 
				_assessmentCandidate.CandidateId,
				(int)rateNumericUpAndDown.Value,
				hasResignedCB.Checked, noteTb.Text));
			rateBtn.Enabled = false;
			await Task.Delay(new TimeSpan(0,0,1));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
		finally
		{
			this.Close();
		}
	}
}