using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SelectCandidatesToWork;

public sealed record SelectCandidatesToWorkCommand(
	Guid JobPostingId,
	List<Guid> CandidateIDs) : IRequest;
