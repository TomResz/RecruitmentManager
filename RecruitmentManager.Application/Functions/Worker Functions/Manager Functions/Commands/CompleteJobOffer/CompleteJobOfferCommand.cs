using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CompleteJobOffer;

public record CompleteJobOfferCommand(
	Guid jobPostingId) : IRequest;