using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfEvaluatedCandidates;

public record GetListOfEvaluatedCandidatesQuery(Guid JobPostingId) : IRequest<List<EvaluatedCandidateDto>>;
