using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.RemoveCandidateFromList;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SelectCandidatesToWork;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.SelectCandidatesToWork;

internal sealed class SelectCandidatesEventHandler
	: IRequestHandler<SelectCandidatesEvent>
{
	private readonly IMediator _mediator;

	public SelectCandidatesEventHandler(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task Handle(SelectCandidatesEvent request, CancellationToken cancellationToken)
	{
		var removeCommand = new RemoveCandidateCommand(request.JobPostingId);
		await _mediator.Send(removeCommand);
		if (request.CandidateIDs.Count is not 0)
		{
			var addCommand = new SelectCandidatesToWorkCommand(
		request.JobPostingId,
		request.CandidateIDs);
			await _mediator.Send(addCommand);
		}
	}
}
