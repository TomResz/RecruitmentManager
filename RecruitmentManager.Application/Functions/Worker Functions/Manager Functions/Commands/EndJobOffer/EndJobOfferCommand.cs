using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.EndJobOffer;

public record EndJobOfferCommand(Guid JobPostingId) : IRequest;
