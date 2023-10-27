using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Register;

public sealed record RegisterCandidateCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string ConfirmedPassword) : IRequest;
