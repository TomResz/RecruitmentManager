using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.EndJobOffer;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SendEmailsToChooseCandidates;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.CompleteRecruitmentProcess;

internal sealed class EndJobOfferEventHandler
	: IRequestHandler<EndJobOfferEvent>
{
	private readonly IMediator _mediator;
	private readonly IDbContext _dbContext;

	public EndJobOfferEventHandler(IMediator mediator, IDbContext dbContext)
	{
		_mediator = mediator;
		_dbContext = dbContext;
	}

	public async Task Handle(EndJobOfferEvent request, CancellationToken cancellationToken)
	{
		var completeRecruitmenProcces = new EndJobOfferCommand(request.JobPostingId);
		await _mediator.Send(completeRecruitmenProcces);

		var candidatesIDs = await _dbContext.Get<SelectedCandidatesToJob>()
			.Where(x => x.JobPostingId == request.JobPostingId)
			.Select(x => x.CandidateId)
			.ToListAsync(cancellationToken);

		var sendEmailsCommand = new SendEmailsToChosenCandidatesCommand(
			 request.JobPostingId, 
			 candidatesIDs);

		await _mediator.Send(sendEmailsCommand);
	}
}
