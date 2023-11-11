using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetSkillsList;

public record GetSkillListQuery(Guid? CandidateId) : IRequest<List<SkillDTO>>;