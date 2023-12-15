using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CreateRatingsForCandidate;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.QualifyCandidateToInterview;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.CheckJobPostingStatus;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events;

public class QualifyToInterviewEventHandler : INotificationHandler<QualifyToInterviewEvent>
{
	private readonly IMediator _mediator;

	public QualifyToInterviewEventHandler(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task Handle(QualifyToInterviewEvent @event, CancellationToken cancellationToken)
	{
		var isCompleted= await _mediator.Send(new CheckJobPostingStatusQuery(@event.JobPostingId), cancellationToken);
		if (isCompleted)
		{
			throw new BadRequestException("Oferta została już zakończona!");
		}
		await _mediator.Send(new QualifyCandidateToInterviewCommand(@event.CandidateId, @event.JobPostingId), cancellationToken);
		await _mediator.Send(new CreateRatingsForCandidateCommand(@event.JobPostingId, @event.CandidateId), cancellationToken);
	}
}