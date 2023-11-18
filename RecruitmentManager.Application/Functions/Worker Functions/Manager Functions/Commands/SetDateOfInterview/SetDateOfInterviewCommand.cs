using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SetDateOfInterview;

public record SetDateOfInterviewCommand(
	Guid CandidateRatingId,
	DateTime Date) : IRequest;