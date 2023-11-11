using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Add;

public record AddHobbyCommand(string Description) : IRequest;