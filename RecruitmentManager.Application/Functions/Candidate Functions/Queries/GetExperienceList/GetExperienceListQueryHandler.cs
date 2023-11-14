using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetExperienceList;

public class GetExperienceListQueryHandler
	: IRequestHandler<GetExperienceListQuery, List<ExperienceDTO>>
{
	private readonly IExperienceRepository _experienceRepository;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IMapper _mapper;
	public GetExperienceListQueryHandler(
		ICandidateSessionContext candidateSessionContext,
		IMapper mapper, IExperienceRepository experienceRepository)
	{
		_candidateSessionContext = candidateSessionContext;
		_mapper = mapper;
		_experienceRepository = experienceRepository;
	}

	public async Task<List<ExperienceDTO>> Handle(
		GetExperienceListQuery request,
		CancellationToken cancellationToken)
	{
		Guid id;
		if (request.CandidateId is null)
		{
			id = _candidateSessionContext.CandidateId 
			     ?? throw new NotFoundException("Invalid candidate ID!");
		}
		else
		{
			id = (Guid)request.CandidateId;
		}

		var query = await _experienceRepository
			.GetByCandidateIdWithoutTracking(id, cancellationToken);
		return _mapper.Map<List<ExperienceDTO>>(query);
	}
}