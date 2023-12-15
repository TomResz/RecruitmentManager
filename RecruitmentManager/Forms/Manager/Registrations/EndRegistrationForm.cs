using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.SelectCandidatesToWork;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetIDsOfSelectedCandidates;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfEvaluatedCandidates;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetNumberOfPositions;
using RecruitmentManager.Controls_Extensions;

namespace RecruitmentManager.Forms.Manager.Registrations;

public partial class EndRegistrationForm : Form
{
	private List<Guid> _listOfSelectedCandidateUIDs = new List<Guid>();
	private int _numberOfPositions;
	private readonly IMediator _mediator;
	private Guid _jobPostingId;
	public EndRegistrationForm(IMediator mediator)
	{
		InitializeComponent();
		_mediator = mediator;
	}

	public async Task LoadForm(Guid jobPostingId)
	{
		_jobPostingId = jobPostingId;
		List<Task> task = new List<Task>();
		task.Add(LoadCounter(jobPostingId));
		task.Add(FillDGV(jobPostingId));
		task.Add(LoadSelectedCandidateIDs(jobPostingId));
		await Task.WhenAll(task);
		SetCheckBoxes();
	}
	private async Task LoadCounter(Guid jobPostingId)
	{
		_numberOfPositions = await _mediator.Send(new GetNumberOfPositionsQuery(jobPostingId));
		candidateCounterLabel.Text += $" {_numberOfPositions}";
	}
	private async Task FillDGV(Guid jobPostingId)
	{
		var query = new GetListOfEvaluatedCandidatesQuery(jobPostingId);
		var response = await _mediator.Send(query);
		usersView.Fill(response, item => new object[]
		{
			item.CandidateId,
			false,
			item.Position,
			item.FullName,
			item.AverageGrade
		});
	}

	private async Task LoadSelectedCandidateIDs(Guid jobPostingId)
		=> _listOfSelectedCandidateUIDs = await _mediator.Send(new GetIDsOfSelectedCandidatesQuery(jobPostingId));


	private List<Guid> GetSelectedCandidateIDs()
	{
		var list = new List<Guid>();
		foreach (DataGridViewRow row in usersView.Rows)
		{
			var cell = row.Cells[1] as DataGridViewCheckBoxCell;
			if (Convert.ToBoolean(cell?.Value) == true)
			{
				if (Guid.TryParse(usersView.Rows[row.Index].Cells[0].Value.ToString(), out var id))
				{
					list.Add(id);
				}
			}
		}
		return list;
	}

	private void SetCheckBoxes()
	{
		foreach (DataGridViewRow row in usersView.Rows)
		{
			if (Guid.TryParse(usersView.Rows[row.Index].Cells[0].Value.ToString(), out var id))
			{
				if (_listOfSelectedCandidateUIDs.Contains(id))
					usersView.Rows[row.Index].Cells[1].Value = true;
				else
					usersView.Rows[row.Index].Cells[1].Value = false;
			}
		}
	}


	private async void endBtn_Click(object sender, EventArgs e)
	{
		var selectedCandidates = GetSelectedCandidateIDs();

		if(selectedCandidates.Count > _numberOfPositions)
		{
			MessageBox.Show("Nie wolno wybrać więcej kandydatów do tej oferty pracy!", 
				"Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}
		endBtn.Enabled = false;
		var @event = new SelectCandidatesEvent(_jobPostingId, selectedCandidates);
		await _mediator.Send(@event);
		await Task.Delay(500);
		this.Close();
	}
}