using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Update;

public record UpdateExperienceCommand(
	Guid Id,
	string Title,
	string CompanyName,
	string Description,
	DateTime Start,
	DateTime? End) : IRequest;