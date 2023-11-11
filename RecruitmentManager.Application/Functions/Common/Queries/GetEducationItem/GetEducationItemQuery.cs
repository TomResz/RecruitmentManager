using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetEducationItem;

public record GetEducationItemQuery(
	Guid EducationId) : IRequest<EducationDTO>;