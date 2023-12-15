using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.RemoveCandidateFromList;

public record RemoveCandidateCommand(Guid JobPostingId) : IRequest;
