using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Add;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Delete;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Update;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetSkillsList;
using RecruitmentManager.Application.Functions.Common.Queries.GetSkillItem;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Candidate.DataDictionary;

public partial class CandidateSkillsView : UserControl
{
	private readonly IMediator _mediator;
	public CandidateSkillsView(IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		InitPb();
		this.Load += CandidateSkillsView_Load;
		skillsDGV.CellClick += SkillsDGV_CellClick;
	}

	private async void SkillsDGV_CellClick(object? sender, DataGridViewCellEventArgs e)
	{
		if(skillsDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(skillsDGV.CurrentRow.Cells[0].Value.ToString(), out var id))
			return;
		var response = await _mediator.Send(new GetSkillItemQuery(id));
		descriptionTextBox.Text = response.Description;
	}

	private async void CandidateSkillsView_Load(object? sender, EventArgs e) => await ReloadDgv();

	private async Task ReloadDgv()
	{
		var response = await _mediator.Send(new GetSkillListQuery(null));
		skillsDGV.Fill(response, item => new object[]
		{
			item.Id,
			item.Description
		});
	}

	private void InitPb()
	{
		var tooltip = new ToolTip();
		descriptionPB.MouseHover += ((sender, args) => tooltip.Show("Opis umiejętności", descriptionPB));
	}

	private void ClearDescription() => descriptionTextBox.Clear();

	private async void addBtn_Click(object sender, EventArgs e)
	{
		try
		{
			var command = new AddSkillCommand(descriptionTextBox.Text);
			await _mediator.Send(command);
			MessageBox.Show("Dodano wpis", "Dodawanie",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearDescription();
			await ReloadDgv();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private async void editBtn_Click(object sender, EventArgs e)
	{

		if(skillsDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(skillsDGV.CurrentRow.Cells[0].Value.ToString(), out var id))
			return;
		var confirmation = MessageBox.Show("Czy napewno chcesz zaktualizować ten wpis?",
			"Aktualizacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation == DialogResult.No)
			return;
		try
		{
			var command = new UpdateSkillCommand(id,descriptionTextBox.Text);
			await _mediator.Send(command);
			MessageBox.Show("Zaktualizowano wpis", "Aktualizacja",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearDescription();
			await ReloadDgv();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private async void deleteBtn_Click(object sender, EventArgs e)
	{
		if (skillsDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(skillsDGV.CurrentRow.Cells[0].Value.ToString(), out var id))
			return;
		var confirmation = MessageBox.Show("Czy napewno chcesz usunąć ten wpis?",
			"Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmation is DialogResult.No)
			return;
		try
		{
			var command = new DeleteSkillCommand(id);
			await _mediator.Send(command);
			MessageBox.Show("Usunięto wpis", "Usuwanie",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearDescription();
			await ReloadDgv();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}