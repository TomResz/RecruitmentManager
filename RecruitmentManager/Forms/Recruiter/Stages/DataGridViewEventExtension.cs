using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Forms.Common_employees;

namespace RecruitmentManager.Forms.Recruiter.Stages;

public static class DataGridViewEventExtension
{
	public static void AttachCustomClickEvent(
		this DataGridView dataGridView, 
		IServiceProvider serviceProvider, 
		ICandidateContext candidateContext) =>
			dataGridView.CellContentClick += (sender, e) => 
				CustomCellContentClick(sender, e, serviceProvider, candidateContext);

	private static void CustomCellContentClick(
		object? sender, 
		DataGridViewCellEventArgs e,
		IServiceProvider serviceProvider, 
		ICandidateContext candidateContext)
	{
		if (e.RowIndex < 0 ||
		    e.ColumnIndex != 6 || 
		    !(sender is DataGridView dataGridView) || 
		    dataGridView.CurrentRow is null ||
		    !Guid.TryParse(dataGridView.CurrentRow.Cells[1].Value.ToString(), out var result))
			return;
		try
		{
			candidateContext.SetId(result);
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

}