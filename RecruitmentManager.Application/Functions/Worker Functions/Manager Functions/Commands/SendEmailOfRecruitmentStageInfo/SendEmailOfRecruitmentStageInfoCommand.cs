using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SendEmailOfRecruitmentStageInfo;

public record SendEmailOfRecruitmentStageInfoCommand(
	Guid CandidateRatingId) : IRequest;
