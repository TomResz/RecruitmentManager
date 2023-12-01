using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Add;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Delete;
using RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Edit;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetHobbiesList;
using RecruitmentManager.Application.Functions.Common.Queries.GetHobbyItem;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Candidate.DataDictionary;

public partial class CandidateHobbyView : UserControl
{
	private readonly IMediator _mediator;
	public CandidateHobbyView(IMediator mediator)
	{
		_mediator = mediator;
		InitializeComponent();
		ActivePictureBox();
		this.Load += CandidateHobbyView_Load;
		hobbiesDGV.CellClick += HobbiesDGV_CellContentDoubleClick;
	}

	private async void HobbiesDGV_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (hobbiesDGV.CurrentRow is null)
			return;
		if (Guid.TryParse(hobbiesDGV.CurrentRow.Cells[0].Value.ToString(), out Guid id))
		{
			var query = new GetHobbyItemQuery(id);
			var response = await _mediator.Send(query);
			descriptionTextBox.Text = response.Description;
		}
	}

	private async void CandidateHobbyView_Load(object? sender, EventArgs e)
		=> await ReloadPage();

	private async Task ReloadPage()
	{
		var query = new GetHobbiesListQuery(null);
		var response = await _mediator.Send(query);
		hobbiesDGV.Fill(response, item => new object[]
		{
			item.Id,
			item.Description
		});
		hobbiesDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		hobbiesDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	private void ActivePictureBox()
	{
		var toolTip = new ToolTip();
		descriptionTextBox.MouseHover += (s, args) => toolTip.Show("Tu należy wpisać zainteresowania.", descriptionTextBox);
		descriptionPB.MouseHover += (s, args) => toolTip.Show("Opis zainteresowania", descriptionPB);
	}

	private async void addBtn_Click(object sender, EventArgs e)
	{
		try
		{
			var command = new AddHobbyCommand(descriptionTextBox.Text);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie dodano wpis!", "Dodawanie",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			await ReloadPage();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}

	private async void editBtn_Click(object sender, EventArgs e)
	{
		if (hobbiesDGV.CurrentRow is null)
			return;
		var confirmationBox = MessageBox.Show("Czy napewno edytować ten wpis?",
			"Edycja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmationBox == DialogResult.No)
			return;
		if (!Guid.TryParse(hobbiesDGV.CurrentRow.Cells[0].Value.ToString(), out Guid id))
			return;
		try
		{
			var command = new EditHobbyCommand(id, descriptionTextBox.Text);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie edytowano wpis!", "Edycja",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			await ReloadPage();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}

	private async void deleteBtn_Click(object sender, EventArgs e)
	{
		if (hobbiesDGV.CurrentRow is null)
			return;
		var confirmationBox = MessageBox.Show("Czy napewno usunać ten wpis?",
			"Edycja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (confirmationBox == DialogResult.No)
			return;
		if (!Guid.TryParse(hobbiesDGV.CurrentRow.Cells[0].Value.ToString(), out Guid id))
			return;
		try
		{
			var command = new DeleteHobbyCommand(id);
			await _mediator.Send(command);
			MessageBox.Show("Pomyślnie usunięto wpis!", "Usuwanie",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
			await ReloadPage();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}

	private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
	{

	}

	private void hobbiesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void leftTableLayout_Paint(object sender, PaintEventArgs e)
	{
	}

	private void buttonTableLayout_Paint(object sender, PaintEventArgs e)
	{
	}

	private void descriptionTextBox_TextChanged(object sender, EventArgs e)
	{
	}

	private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void descriptionPB_Click(object sender, EventArgs e)
	{
	}
}