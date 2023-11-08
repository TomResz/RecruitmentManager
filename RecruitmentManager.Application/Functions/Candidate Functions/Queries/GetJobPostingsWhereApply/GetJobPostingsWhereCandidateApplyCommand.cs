using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingsWhereApply;

public record GetJobPostingsWhereCandidateApplyCommand(
		Guid CandidateId) : IRequest<List<JobOffersWhereCandidateAppliedViewDto>>;