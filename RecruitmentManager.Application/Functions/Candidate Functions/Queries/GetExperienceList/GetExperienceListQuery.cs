using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetExperienceList;

public record GetExperienceListQuery(
	Guid? CandidateId) : IRequest<List<ExperienceDTO>>;