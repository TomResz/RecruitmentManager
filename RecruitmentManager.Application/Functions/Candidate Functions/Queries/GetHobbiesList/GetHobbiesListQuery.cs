using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetHobbiesList;

public record GetHobbiesListQuery(
	Guid? CandidateId) : IRequest<List<HobbyDTO>>;