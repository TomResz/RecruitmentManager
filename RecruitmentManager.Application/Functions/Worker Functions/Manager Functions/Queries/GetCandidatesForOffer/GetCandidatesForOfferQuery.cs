using MediatR;
using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetCandidatesForOffer;

public record GetCandidatesForOfferQuery(
	Guid JobPostingId) : IRequest<List<CandidateDTO>>;