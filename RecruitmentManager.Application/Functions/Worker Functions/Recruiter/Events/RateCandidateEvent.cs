using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Events;

public sealed record RateCandidateEvent(
	Guid CandidateRatingId,
	Guid CandidateId,
	int Grade,
	bool HasResigned,
	string Notes) : INotification;