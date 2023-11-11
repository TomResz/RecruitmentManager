using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Delete;

public record DeleteEducationCommand(
	Guid Id) : IRequest;