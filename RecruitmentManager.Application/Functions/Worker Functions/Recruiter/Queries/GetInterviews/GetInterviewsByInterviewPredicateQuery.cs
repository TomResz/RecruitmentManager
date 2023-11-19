using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;

public record GetInterviewsByInterviewPredicateQuery(
	InterviewPredicate InterviewPredicate) : IRequest<List<InterviewDto>>;