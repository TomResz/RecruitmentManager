using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetEducationsList;

public record GetEducationListQuery(
	Guid? CandidateId) : IRequest<List<EducationDTO>>;