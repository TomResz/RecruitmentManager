using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateDataToEdit;

public record GetCandidateDataToEditQuery(Guid CandidateId) 
	: IRequest<CandidateDataToEditDTO>;