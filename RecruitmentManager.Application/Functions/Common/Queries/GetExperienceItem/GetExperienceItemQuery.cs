using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetExperienceItem;

public record GetExperienceItemQuery(Guid id) : IRequest<ExperienceDTO>;