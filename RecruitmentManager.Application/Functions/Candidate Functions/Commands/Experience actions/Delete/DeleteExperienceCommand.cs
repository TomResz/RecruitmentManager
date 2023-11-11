using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Delete;

public record DeleteExperienceCommand(
		Guid ExperienceId) : IRequest;