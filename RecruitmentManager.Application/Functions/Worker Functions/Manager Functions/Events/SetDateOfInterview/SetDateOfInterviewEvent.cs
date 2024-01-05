using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.SetDateOfInterview;

public record SetDateOfInterviewEvent(
	Guid CandidateRatingId,
	DateTime Date) : IRequest;
