using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetIDsOfSelectedCandidates;

public record GetIDsOfSelectedCandidatesQuery(Guid JobPostingId) : IRequest<List<Guid>>;
