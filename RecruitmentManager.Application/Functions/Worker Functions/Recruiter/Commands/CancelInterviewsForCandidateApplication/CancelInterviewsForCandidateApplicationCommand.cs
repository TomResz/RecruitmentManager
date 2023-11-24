using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Commands.CancelInterviewsForCandidateApplication;

public record CancelInterviewsForCandidateApplicationCommand(
	Guid CandidateRatingId,
	Guid CandidateId) : IRequest;