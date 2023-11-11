using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Delete;

public record DeleteSkillCommand(Guid Id) : IRequest;