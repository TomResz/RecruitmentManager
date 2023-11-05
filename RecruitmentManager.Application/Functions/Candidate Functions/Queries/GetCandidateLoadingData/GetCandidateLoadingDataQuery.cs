using MediatR;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateLoadingData;

public record GetCandidateLoadingDataQuery(Guid CandidateId) 
	: IRequest<CandidateLoadingData>;