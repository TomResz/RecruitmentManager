using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetExperienceList;

public class GetExperienceListQueryHandler
	: IRequestHandler<GetExperienceListQuery, List<ExperienceDTO>>
{
	private readonly IDbContext _context;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IMapper _mapper;
	public GetExperienceListQueryHandler(IDbContext context,
		ICandidateSessionContext candidateSessionContext,
		IMapper mapper)
	{
		_context = context;
		_candidateSessionContext = candidateSessionContext;
		_mapper = mapper;
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

		var query = await _context
			.Get<Experience>()
			.Where(x=>x.CandidateId == id)
			.AsNoTracking()
			.ToListAsync(cancellationToken: cancellationToken);
		return _mapper.Map<List<ExperienceDTO>>(query);
	}
}