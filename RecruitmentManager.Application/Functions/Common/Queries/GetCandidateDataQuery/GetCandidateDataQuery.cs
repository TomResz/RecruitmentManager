using MediatR;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetCandidateDataQuery;

public record GetCandidateDataQuery(
		Guid CandidateId) : IRequest<GetCandidateDataResponse>;