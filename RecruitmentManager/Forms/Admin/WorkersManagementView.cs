using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.Delete_Worker;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries.GetPageOfWorkers;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Pagination;

namespace RecruitmentManager.Forms.Admin;

public partial class WorkersManagementView : UserControl
{
	private PagedList<WorkerViewDTO> _workersPagedList;

	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private readonly IUserDataToEditContext _workerDataToEditContext;
	private int _page = 1;
	private int _pageSize = 10;

	public WorkersManagementView(
		IServiceProvider serviceProvider,
		IMediator mediator,
		IUserDataToEditContext workerDataToEditContext)
	{
		InitializeComponent();
		_serviceProvider = serviceProvider;
		_mediator = mediator;
		Load += WorkersManagementView_Load;
		_workerDataToEditContext = workerDataToEditContext;
	}

	private async void WorkersManagementView_Load(object? sender, EventArgs e)
	{
		await ReloadPage();
	}



	private void RefreshDataGridView()
	{
		workersDGV.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		workersDGV.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		workersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		workersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
		workersDGV.Rows.Clear();
		foreach (var item in _workersPagedList.Items)
		{
			workersDGV.Rows.Add(new object[]
			{
				item.Id,
				item.Email,
				item.FullName,
				item.Role
			});
		}
	}

	private async Task ReloadPage()
	{
		await GetPageItems();
		RefreshPageCounter();
		RefreshDataGridView();

	}
	private async Task GetPageItems()
	{
		var pageRequest = new GetPageOfWorkersQuery(_page, _pageSize);
		_workersPagedList = await _mediator.Send(pageRequest);
	}

	private void RefreshPageCounter()
		=> pageCounterLabel.Text = $"{_workersPagedList.Page}/{_workersPagedList.PageTotalCount}";

	private async void nextPageButton_Click(object sender, EventArgs e)
	{
		if (_workersPagedList.HasNextPage)
		{
			++_page;
			await ReloadPage();
		}
	}

	private async void previousPageButton_ClickAsync(object sender, EventArgs e)
	{
		if (_workersPagedList.HasPreviousPage)
		{
			--_page;
			await ReloadPage();
		}
	}

	private async void addEmployeeBtn_Click(object sender, EventArgs e)
	{
		var form = _serviceProvider.GetRequiredService<AddWorkerForm>();
		form.ShowDialog();
		await ReloadPage();
	}

	private async void deleteBtn_Click(object sender, EventArgs e)
	{
		if (workersDGV.CurrentRow is null)
			return;
		var id = workersDGV.CurrentRow.Cells[0]?.Value.ToString();
		if (id is null)
			return;
		var confirmationBox = MessageBox.Show(
			   text: "Czy napewno chcesz usunąć tego pracownika?",
			caption: "Usuwanie pracowników.",
			buttons: MessageBoxButtons.YesNo,
			icon: MessageBoxIcon.Question);
		if (confirmationBox == DialogResult.Yes)
		{
			try
			{
				if (Guid.TryParse(id, out Guid uid))
				{
					var command = new DeleteEmployeeCommand(uid);
					await _mediator.Send(command);
					await ReloadPage();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					text: ex.Message,
					caption: "Błąd",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
			}
		}
	}

	private void workersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && e.ColumnIndex == 4)
		{

			var id = workersDGV.CurrentRow.Cells[0]?.Value.ToString();
			var email = workersDGV.CurrentRow.Cells[1].Value.ToString();
			Guid ID;
			if (Guid.TryParse(id, out Guid uid) && email is not null)
			{
				ID = uid;
				_workerDataToEditContext.SetData(ID, email);
				try
				{
					var form = _serviceProvider.GetRequiredService<ResetWorkerPasswordForm>();
					form.ShowDialog();
				}
				finally
				{
					_workerDataToEditContext.Clear();
				}
			}

		}
	}

}
