using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Login;

public sealed record LoginCandidateCommand(
	string Email,
	string Password) : IRequest<Guid>;
