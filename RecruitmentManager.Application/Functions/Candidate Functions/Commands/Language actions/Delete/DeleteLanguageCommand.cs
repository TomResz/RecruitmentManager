using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Delete;

public record DeleteLanguageCommand(Guid Id) : IRequest;