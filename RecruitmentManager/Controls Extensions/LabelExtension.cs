using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Controls_Extensions;

public static class LabelExtension
{
	public static void SetPageCounter<T>(
		this Label label,
		PagedList<T> list) 
		=> label.Text = $@"{list.Page}/{list.PageTotalCount}";
}