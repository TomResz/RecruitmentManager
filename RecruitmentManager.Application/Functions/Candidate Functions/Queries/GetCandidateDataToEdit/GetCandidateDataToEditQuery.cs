using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateDataToEdit;

public record GetCandidateDataToEditQuery(Guid CandidateId) 
	: IRequest<CandidateDataToEditDTO>;