using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.CompleteRecruitmentProcess;

public record EndJobOfferEvent(
	Guid JobPostingId) : IRequest;
