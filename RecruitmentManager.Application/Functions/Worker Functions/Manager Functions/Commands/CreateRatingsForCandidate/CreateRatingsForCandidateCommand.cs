using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CreateRatingsForCandidate;

public record CreateRatingsForCandidateCommand(
	Guid JobPostingId,
	Guid CandidateId) : IRequest;