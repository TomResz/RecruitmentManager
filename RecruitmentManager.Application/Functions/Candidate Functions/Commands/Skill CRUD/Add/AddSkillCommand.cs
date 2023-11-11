using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Add;

public record AddSkillCommand(string Description) : IRequest;