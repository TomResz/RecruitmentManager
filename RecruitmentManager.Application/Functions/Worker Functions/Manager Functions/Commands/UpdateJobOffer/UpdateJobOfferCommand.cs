using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.UpdateJobOffer;

public record UpdateJobOfferCommand(
	Guid Id,
	string Title,
	string Description,
	int NumberOfPositions,
	DateTime CreatedDate,
	DateTime EndDate,
	List<RecruitmentStagesToEditDto> StagesToEdit) : IRequest;