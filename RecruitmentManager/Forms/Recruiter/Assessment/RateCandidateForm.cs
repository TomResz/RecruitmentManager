using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Forms.Recruiter.Assessment;

public partial class RateCandidateForm : Form
{
	private readonly IAssessmentCandidate _assessmentCandidate;
	public RateCandidateForm(IAssessmentCandidate assessmentCandidate)
	{
		_assessmentCandidate = assessmentCandidate;
		InitializeComponent();
		ActivePictureBoxes();
	}

	private void ActivePictureBoxes()
	{
		var tip = new ToolTip();
		notesPB.MouseHover += (s, args) => tip.Show("Notatki", notesPB);
		ratePB.MouseHover += (s, args) => tip.Show("Ocena", ratePB);
	}

	private void rateBtn_Click(object sender, EventArgs e)
	{
		
	}
}