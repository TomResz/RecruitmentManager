using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ApplyForJobPosting;

public record ApplyForJobPostingCommand(
	Guid JobPostingId,
	Guid CandidateId) : IRequest;