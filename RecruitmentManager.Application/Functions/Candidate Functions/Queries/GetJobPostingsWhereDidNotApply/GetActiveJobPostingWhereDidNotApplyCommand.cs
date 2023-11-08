using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingWhereDidNotApply;

public record GetActiveJobPostingWhereDidNotApplyCommand(
	Guid CandidateId) : IRequest<List<JobOffersViewDto>>;