using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SendEmailOfRecruitmentStageInfo;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SetDateOfInterview;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.SetDateOfInterview;

internal sealed class SetDateOfInterviewEventHandler
	: IRequestHandler<SetDateOfInterviewEvent>
{
	private readonly IMediator _mediator;

	public SetDateOfInterviewEventHandler(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task Handle(SetDateOfInterviewEvent request, CancellationToken cancellationToken)
	{
		var command = new SetDateOfInterviewCommand(
			 request.CandidateRatingId, 
			 request.Date);
		await _mediator.Send(command);

		var emailCommand = new SendEmailOfRecruitmentStageInfoCommand(
			   request.CandidateRatingId);
		await _mediator.Send(emailCommand);
	}
}
