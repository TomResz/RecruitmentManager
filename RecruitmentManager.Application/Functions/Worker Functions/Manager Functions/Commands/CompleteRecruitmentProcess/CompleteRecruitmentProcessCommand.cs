using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CompleteRecruitmentProcess;

public record CompleteRecruitmentProcessCommand(Guid JobPostingId) : IRequest;
