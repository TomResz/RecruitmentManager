using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate.Login;

public sealed record LoginCandidateCommand(
	string Email,
	string Password) : IRequest<Guid>;
