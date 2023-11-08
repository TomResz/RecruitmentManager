using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.RecruiterList;

public sealed record GetRecruitersListQuery() 
	: IRequest<List<RecruiterDto>>;