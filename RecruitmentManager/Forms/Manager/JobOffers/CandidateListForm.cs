using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfSelectedCandidates;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Controls_Extensions;
using RecruitmentManager.Forms.Common_employees;

namespace RecruitmentManager.Forms.Manager.JobOffers;

public partial class CandidateListForm : Form
{
	private Guid _jobPostingId;
	private readonly IMediator _mediator;
	private readonly IServiceProvider _serviceProvider;
	private readonly ICandidateContext _candidateContext;
	public CandidateListForm(IMediator mediator, IServiceProvider serviceProvider, ICandidateContext candidateContext)
	{
		InitializeComponent();
		ChangeSize();
		usersView.SizeChanged += (s, args) => ChangeSize();
		usersView.CellClick += UsersView_CellClick;
		_mediator = mediator;
		_serviceProvider = serviceProvider;
		_candidateContext = candidateContext;
	}

	private void UsersView_CellClick(object? sender, DataGridViewCellEventArgs e)
	{
		if(e is { RowIndex: >= 0, ColumnIndex: 2 })
		{
			if (usersView.CurrentRow is not null  &&
				Guid.TryParse(usersView.CurrentRow.Cells[0].Value.ToString(), out var candidateId))
			{
				try
				{
					_candidateContext.SetId(candidateId);
					var form = _serviceProvider.GetRequiredService<ShowFullCandidateDataForm>();
					form.ShowDialog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
				finally
				{
					_candidateContext.Logout();
				}
			}
		}
	}

	private void ChangeSize()
	{
		usersView.Columns[1].Width = (int)(usersView.Width * 0.70);
		usersView.Columns[2].Width = (int)(usersView.Width * 0.30);
		usersView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		usersView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	public async Task Load(Guid jobPostingId)
	{
		_jobPostingId = jobPostingId;
		var response = await _mediator.Send(new GetListOfSelectedCandidatesQuery(jobPostingId));
		usersView.Fill(response, item => new object[]
		{
			item.Id,
			item.FullName
		});
	}
}
