namespace RecruitmentManager.Controls_Extensions;

public static class JobOfferDGVSettings
{
	public static void ApplyJobOfferSettings(
		this DataGridView view)
	{
		view.Columns[1].Width = (int)(view.Width * 0.5);
		view.Columns[2].Width = (int)(view.Width * 0.15);
		view.Columns[3].Width = (int)(view.Width * 0.15);
		view.Columns[4].Width = (int)(view.Width * 0.2);
		view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		view.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		view.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		view.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		view.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		view.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
	}
}