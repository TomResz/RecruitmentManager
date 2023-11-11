using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetSkillItem;

public record GetSkillItemQuery(Guid SkillId) : IRequest<SkillDTO>;