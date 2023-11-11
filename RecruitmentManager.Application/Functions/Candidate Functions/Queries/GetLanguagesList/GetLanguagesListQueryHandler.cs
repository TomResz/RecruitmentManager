using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetLanguagesList;

public class GetLanguagesListQueryHandler
	: IRequestHandler<GetLanguagesListQuery,List<KnowledgeOfLanguageDTO>>
{
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IKnowledgeOfLanguageRepository _knowledgeOfLanguageRepository;
	private readonly IMapper _mapper;
	public GetLanguagesListQueryHandler(
		IMapper mapper,
		ICandidateSessionContext candidateSessionContext, IKnowledgeOfLanguageRepository knowledgeOfLanguageRepository)
	{
		_mapper = mapper;
		_candidateSessionContext = candidateSessionContext;
		_knowledgeOfLanguageRepository = knowledgeOfLanguageRepository;
	}

	public async Task<List<KnowledgeOfLanguageDTO>> Handle(
		GetLanguagesListQuery request, 
		CancellationToken cancellationToken)
	{
		Guid uid;
		if (request.CandidateId is null)
		{
			uid = _candidateSessionContext.CandidateId 
			      ?? throw new NotFoundException("Invalid candidate ID!");
		}
		else
		{
			uid = (Guid)request.CandidateId;
		}

		var results = await _knowledgeOfLanguageRepository
			.GetAllByCandidateId(uid);
		if (results is null)
		{
			throw new NotFoundException(nameof(results));
		}
		return _mapper.Map<List<KnowledgeOfLanguageDTO>>(results);	
	}
}