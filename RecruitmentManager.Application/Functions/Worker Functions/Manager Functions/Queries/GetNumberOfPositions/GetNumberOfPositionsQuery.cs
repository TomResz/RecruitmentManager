using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetNumberOfPositions;

public sealed record GetNumberOfPositionsQuery(Guid JobPostingId) : IRequest<int>;
