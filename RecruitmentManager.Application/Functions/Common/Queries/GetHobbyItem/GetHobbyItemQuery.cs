using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetHobbyItem;

public record GetHobbyItemQuery(Guid Id) : IRequest<HobbyDTO>;