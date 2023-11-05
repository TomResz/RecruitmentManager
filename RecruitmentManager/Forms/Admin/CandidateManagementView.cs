using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.Delete_Candidate;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries.GetPageOfCandidates;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Forms.Admin;

public partial class CandidateManagementView : UserControl
{
	private PagedList<CandidateViewDTO> _candidatePageList;
	private readonly IMediator _mediator;
	private readonly IUserDataToEditContext _userDataToEditContext;
	private readonly IServiceProvider _serviceProvider;

	private int _page = 1;
	private int _pageSize = 10;

	public CandidateManagementView(
		IMediator mediator,
		IUserDataToEditContext userDataToEditContext,
		IServiceProvider serviceProvider)
	{
		InitializeComponent();
		_mediator = mediator;
		_userDataToEditContext = userDataToEditContext;
		_serviceProvider = serviceProvider;
		candidateDGV.Visible = false;
		Load += CandidateManagementView_Load;
	}

	private async void CandidateManagementView_Load(object? sender, EventArgs e)
	{
		await ReloadPage();
	}

	private async void deleteBtn_Click(object sender, EventArgs e)
	{
		if (candidateDGV.CurrentRow is null)
			return;
		var id = candidateDGV.CurrentRow.Cells[0]?.Value.ToString();
		if (!Guid.TryParse(id, out Guid ID))
		{
			return;
		}
		var uid = ID;
		var confirmationResult = MessageBox.Show(
			  text: "Czy napewno chcesz usunąc tego użytkownika?",
			caption: "Usuwanie użytkowników.",
			buttons: MessageBoxButtons.YesNo,
			  icon: MessageBoxIcon.Question);
		if (confirmationResult == DialogResult.Yes)
		{
			try
			{
				var command = new DeleteCandidateCommand(uid);
				await _mediator.Send(command);

				MessageBox.Show("Usunięto użytkownika.", "Usuwanie użytkowników.",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				await ReloadPage();
			}
			catch (Exception ex)
			{
				MessageBox.Show(text: ex.Message,
					caption: "Error!",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
			}
		}
	}

	private async void previousPageButton_Click(object sender, EventArgs e)
	{
		if (_candidatePageList.HasPreviousPage)
		{
			--_page;
			await ReloadPage();
		}
	}

	private async void nextPageButton_Click(object sender, EventArgs e)
	{
		if (_candidatePageList.HasNextPage)
		{
			++_page;
			await ReloadPage();
		}
	}

	private async Task ReloadPage()
	{
		var command = new GetPageOfCandidatesQuery(_page, _pageSize);
		_candidatePageList = await _mediator.Send(command);
		LoadDataGridView();
		SetLabel();
		candidateDGV.Visible = _candidatePageList.Items.Count is not 0;
	}

	private void SetLabel()
		=> pageCounterLabel.Text = $"{_candidatePageList.Page}/{_candidatePageList.PageTotalCount}";


	private void LoadDataGridView()
	{
		if (_candidatePageList.Items.Count == 0)
		{
			candidateDGV.Visible = false;
			return;
		}
		candidateDGV.Rows.Clear();
		foreach (var item in _candidatePageList.Items)
		{
			candidateDGV.Rows.Add(new object[]
			{
				item.Id,
				item.Email,
				item.FullName
			});
		}
	}

	private void candidateDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex == 3)
		{
			var id = candidateDGV.CurrentRow.Cells[0].Value.ToString();
			var email = candidateDGV.CurrentRow.Cells[1].Value.ToString();
			if (Guid.TryParse(id, out Guid uid) && email is not null)
			{
				try
				{
					_userDataToEditContext.SetData(uid, email);
					var form = _serviceProvider.GetRequiredService<ResetCandidatePasswordForm>();
					form.ShowDialog();
				}
				finally
				{
					_userDataToEditContext.Clear();
				}
			}
		}
	}

	private async void addBtn_Click(object sender, EventArgs e)
	{
		var form = _serviceProvider.GetRequiredService<AddCandidateForm>();
		form.ShowDialog();
		await ReloadPage();
	}
}

