using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Commands.CancelInterviewsForCandidateApplication;
using RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Commands.RateCandidate;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Events;

public class RateCandidateEventHandler : INotificationHandler<RateCandidateEvent>
{
	private readonly IMediator _mediator;

	public RateCandidateEventHandler(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task Handle(RateCandidateEvent @event, CancellationToken cancellationToken)
	{
		if (@event.HasResigned)
		{
			await _mediator.Send(
				new CancelInterviewsForCandidateApplicationCommand(@event.CandidateRatingId, @event.CandidateId),
				cancellationToken);
		}
		else
		{
			await _mediator.Send(new RateCandidateCommand(
				@event.CandidateRatingId,
				@event.CandidateId,
				@event.Grade,
				@event.Notes), cancellationToken);
		}
	}
}