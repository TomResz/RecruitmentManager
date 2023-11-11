using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Add;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Delete;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Update;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetLanguagesList;
using RecruitmentManager.Application.Functions.Common.Queries.GetLanguageItem;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Forms.Candidate.DataDictionary;

public partial class CandidateLanguageKnowledgeView : UserControl
{
	private readonly IMediator _mediator;
	public CandidateLanguageKnowledgeView(IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		languageDGV.SizeChanged += (s, args) => ChangeSize();
		this.Load += CandidateLanguageKnowledgeView_Load;
		ActivePictureBoxes();
		languageDGV.CellClick += LanguageDGV_CellClick;
		
	}

	private async void LanguageDGV_CellClick(object? sender, DataGridViewCellEventArgs e)
	{
		if(languageDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(languageDGV.CurrentRow.Cells[0].Value.ToString(), out var id))
			return;
		var query = new GetLanguageItemQuery(id);
		var response = await _mediator.Send(query);
		languageComboBox.SelectedItem = response.Language;
		levelOfKnowledgeComboBox.SelectedItem = ConvertLevelIdToString(response.LanguageProficiencyLevelId);
	}

	private void ActivePictureBoxes()
	{
		var toolTip = new ToolTip();
		languagePB.MouseHover += (s, args) => toolTip.Show("Język", languagePB);
		pictureBox1.MouseHover += (s, args) => toolTip.Show("Poziom znajomości", pictureBox1);
	}

	private async void CandidateLanguageKnowledgeView_Load(object? sender, EventArgs e)
		=> await ReloadDgv();

	private void ChangeSize()
	{
		languageDGV.Columns[1].Width = (int)(languageDGV.Width * 0.6);
		languageDGV.Columns[2].Width = (int)(languageDGV.Width * 0.4);
		languageDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		languageDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private LanguageLevel ConvertComboBoxValueToLanguageLevel
		=> levelOfKnowledgeComboBox.Text switch
		{
			"A1" => LanguageLevel.A1,
			"A2" => LanguageLevel.A2,
			"B1" => LanguageLevel.B1,
			"B2" => LanguageLevel.B2,
			"C1" => LanguageLevel.C1,
			"C2" => LanguageLevel.C2,
			_ => throw new InvalidDataException("Nie wybrano poziomu trudności!")
		};
	private string GetLanguage
		=> string.IsNullOrEmpty(languageComboBox.Text)
		? throw new InvalidDataException("Nie wybrano języka!")
		: languageComboBox.Text;

	public async Task ReloadDgv()
	{
		var query = new GetLanguagesListQuery(null);
		var response = await _mediator.Send(query);
		languageDGV.Fill(response, item => new object[]
		{
			item.Id,
			item.Language,
			ConvertLevelIdToString(item.LanguageProficiencyLevelId)
		});
	}

	public string ConvertLevelIdToString(int level)
	{
		if (Enum.IsDefined(typeof(LanguageLevel), level))
		{
			return ((LanguageLevel)level).ToString();
		}
		else
		{
			return "A1";
		}
	}


	private async void editBtn_Click(object sender, EventArgs e)
	{
		if (languageDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(languageDGV.CurrentRow.Cells[0].Value.ToString(), out var uid))
			return;
		var confirmation = MessageBox.Show("Czy napewno chcesz zaktualizować ten wpis?",
			"Aktualizowanie wpisu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
		if (confirmation == DialogResult.No)
			return;
		try
		{
			var command = new UpdateLanguageCommand(
				uid,
				GetLanguage,
				ConvertComboBoxValueToLanguageLevel);
			await _mediator.Send(command);
			await ReloadDgv();
			MessageBox.Show("Pomyślnie zaktualizowano dane!", "Aktualizacja danych",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}

	private async void addBtn_Click(object sender, EventArgs e)
	{
		try
		{
			var command = new AddLanguageCommand(GetLanguage, ConvertComboBoxValueToLanguageLevel);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie dodano język!", "Dodawanie",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			await ReloadDgv();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}

	private async void deleteBtn_Click(object sender, EventArgs e)
	{
		if (languageDGV.CurrentRow is null)
			return;
		if (!Guid.TryParse(languageDGV.CurrentRow.Cells[0].Value.ToString(), out var uid))
			return;
		var confirmation = MessageBox.Show("Czy napewno chcesz usunąć ten wpis?",
			"Usuwanie wpisu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
		if (confirmation == DialogResult.No)
			return;
		try
		{
			var command = new DeleteLanguageCommand(uid);
			await _mediator.Send(command);
			await ReloadDgv();
			MessageBox.Show("Pomyślnie usunięto dane!", "Usuwanie danych",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}


}