using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Delete;

public record DeleteHobbyCommand(
	Guid HobbyId) : IRequest;