using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Commands.RateCandidate;

public sealed record RateCandidateCommand(
	Guid CandidateRatingId,
	Guid CandidateId,
	int Grade,
	string Notes) : IRequest;