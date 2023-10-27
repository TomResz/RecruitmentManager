using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ResetPassword;

public record CandidateResetPasswordCommand(
	Guid CandidateId,
	string Password,
	string ConfirmedPassword) : IRequest;
