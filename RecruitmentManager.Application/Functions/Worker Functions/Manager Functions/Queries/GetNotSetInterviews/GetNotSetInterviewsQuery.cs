using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetNotSetInterviews;

public record GetNotSetInterviewsQuery() : IRequest<List<InterviewDto>>;