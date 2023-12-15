using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.SelectCandidatesToWork;

public record SelectCandidatesEvent(
	Guid JobPostingId,
	List<Guid> CandidateIDs) : IRequest;

