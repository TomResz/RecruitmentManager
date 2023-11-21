using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Common_employees;

namespace RecruitmentManager.Forms.Recruiter.Assessment;

public static class DGVAssessmentExtension
{
	public static void AssessmentCustomClickEvent(
		this DataGridView dataGridView,
		IServiceProvider serviceProvider,
		ICandidateContext candidateContext, IAssessmentCandidate assessmentCandidate) =>
		dataGridView.CellContentClick += (sender, e) =>
			CustomCellContentClick(sender, e, serviceProvider, candidateContext,assessmentCandidate);

	private static void CustomCellContentClick(
		object? sender,
		DataGridViewCellEventArgs e,
		IServiceProvider serviceProvider,
		ICandidateContext candidateContext, 
		IAssessmentCandidate assessmentCandidate)
	{
		if (!(sender is DataGridView dataGridView) ||
		    dataGridView.CurrentRow is null ||
		    !Guid.TryParse(dataGridView.CurrentRow.Cells[1].Value.ToString(), out var candidateId) ||
		    !Guid.TryParse(dataGridView.CurrentRow.Cells[0].Value.ToString(),out var jobApplicationId))
			return;
		if (e is { RowIndex: >= 0, ColumnIndex: 6 })
		{
			try
			{
				candidateContext.SetId(candidateId);
				var form = serviceProvider.GetRequiredService<ShowFullCandidateDataForm>();
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				candidateContext.Logout();
			}
		}
		else if (e is { RowIndex: >= 0, ColumnIndex: 7 })
		{
			try
			{
				assessmentCandidate.Set(candidateId,jobApplicationId);
				var form = serviceProvider.GetRequiredService<RateCandidateForm>();
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				assessmentCandidate.Clear();
			}
		}

	}
}