using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateInterviews;

public record GetCandidateInterviewsQuery(
	CandidateInterviewPredicate InterviewPredicate) : IRequest<List<InterviewDto>>;