using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.UpdateData;

public record UpdateCandidateDataCommand(
	CandidateBasicDataDTO BasicDataDto) : IRequest;