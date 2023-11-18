using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.QualifyCandidateToInterview;

public record QualifyCandidateToInterviewCommand(
	Guid CandidateId,
	Guid JobPostingId) : IRequest;