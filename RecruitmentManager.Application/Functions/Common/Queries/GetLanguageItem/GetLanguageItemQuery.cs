using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetLanguageItem;

public record GetLanguageItemQuery(
	Guid id) : IRequest<KnowledgeOfLanguageDTO>;