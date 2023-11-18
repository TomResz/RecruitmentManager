using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries.GetInterviewData;

public record GetInterviewDataQuery(
	bool Actual) : IRequest<List<InterviewDto>>;