using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Recruiter.Stages;

public static class DGVExtensions
{
	public static void FillJobStagesDgv(this DataGridView dataGridView, List<InterviewWithCandidateIdDto> list)
	{
		dataGridView.Fill(list,item => new object[]
		{
			item.Id,
			item.CandidateId,
			item.JobTitle,
			item.StageName,
			item.CandidateFullName,
			item.Date.HasValue ? item.Date.Value.ToString("dd-MM-yyyy HH:mm") : "Brak",
		});
	}

	public static void JobStagesChangeSize(this DataGridView stagesDgv)
	{
		stagesDgv.Columns[2].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[3].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[4].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[5].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.Columns[6].Width = (int)(stagesDgv.Width * 0.2);
		stagesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		stagesDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}
}