namespace RecruitmentManager.Controls_Extensions;

public static class TableLayoutExtension
{
	public static void ShowControl(
		this TableLayoutPanel mainLayout,
		UserControl controlToShow, 
		ref UserControl? currentControl,
		int column = 0,
		int row = 1)
	{
		if (currentControl != controlToShow)
		{
			if (currentControl is not null)
				currentControl.Visible = false;

			if (!mainLayout.Controls.Contains(controlToShow))
			{
				controlToShow.Dock = DockStyle.Fill;
				mainLayout.Controls.Add(controlToShow, column, row);
			}

			controlToShow.Visible = true;
			currentControl = controlToShow;
		}
	}
	
}