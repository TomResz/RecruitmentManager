using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.Delete_Candidate;

public sealed record DeleteCandidateCommand(
	Guid Id) : IRequest;
