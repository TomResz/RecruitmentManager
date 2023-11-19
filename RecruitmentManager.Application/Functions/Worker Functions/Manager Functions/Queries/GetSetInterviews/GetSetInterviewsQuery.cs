using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetSetInterviews;

public record GetSetInterviewsQuery() : IRequest<List<InterviewDto>>;