using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Update;

public record UpdateEducationCommand(
	Guid Id,
	string SchoolName,
	string Major,
	int LevelOfEducationId,
	DateTime Start,
	DateTime? End) : IRequest;