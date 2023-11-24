using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.CheckJobPostingStatus;

public record CheckJobPostingStatusQuery(Guid JobPostingId) : IRequest<bool>;