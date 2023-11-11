using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Add;

public record AddEducationCommand(
	string SchoolName,
	string Major,
	int LevelOfEducationId,
	DateTime Start,
	DateTime? End) : IRequest;