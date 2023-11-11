using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Edit;

public record EditHobbyCommand(
	Guid HobbyId,
	string Description) : IRequest;