using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Update;

public record UpdateSkillCommand(
		Guid Id, 
		string Description) : IRequest;