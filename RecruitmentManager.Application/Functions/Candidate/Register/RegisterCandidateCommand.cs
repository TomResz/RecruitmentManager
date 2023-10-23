using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate.Register;

public sealed record RegisterCandidateCommand(
    string Email,
    string Password,
    string ConfirmedPassword) : IRequest;
