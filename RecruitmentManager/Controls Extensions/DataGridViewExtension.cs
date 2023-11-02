namespace RecruitmentManager.Controls_Extensions;

public static class DataGridViewExtension
{
	public static void Fill<T>(
		this DataGridView dataGridView,
		IEnumerable<T> items,
		Func<T, object[]> rowDataSelector) where T : class
	{
		dataGridView.Rows.Clear();
		dataGridView.Rows.AddRange(items.Select(item =>
		{
			var row = new DataGridViewRow();
			row.CreateCells(dataGridView, rowDataSelector(item));
			return row;
		}).ToArray());
	}
}