using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CreateJobOffer;

public record CreateJobOfferCommand(
	string Title,
	string Description,
	int NumberOfPositions,
	DateTime CreatedDate,
	DateTime EndDate,
	List<RecruitmentStagesDto> RecruitmentStagesDtos) : IRequest;
