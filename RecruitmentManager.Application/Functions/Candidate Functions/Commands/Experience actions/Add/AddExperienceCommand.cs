using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Add;

public record AddExperienceCommand(
	string Title,
	string CompanyName,
	string Description,
	DateTime Start,
	DateTime? End) : IRequest;