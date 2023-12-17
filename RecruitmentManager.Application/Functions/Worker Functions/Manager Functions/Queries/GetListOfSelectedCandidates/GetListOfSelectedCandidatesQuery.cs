using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfSelectedCandidates;

public record GetListOfSelectedCandidatesQuery(
	Guid JobPostingId) : IRequest<List<CandidateResponse>>;
