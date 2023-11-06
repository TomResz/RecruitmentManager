using MediatR;
using RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateDataToEdit;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.UpdateData;

public record UpdateCandidateDataCommand(
	CandidateDataToEditDTO DataToEditDto) : IRequest;