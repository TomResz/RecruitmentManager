using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetLanguageItem;

public class GetLanguageItemQueryHandler 
	: IRequestHandler<GetLanguageItemQuery,KnowledgeOfLanguageDTO>
{
	private readonly IAsyncRepository<KnowledgeOfLanguage> _asyncRepository;
	private readonly IMapper _mapper;
	public GetLanguageItemQueryHandler(
		IAsyncRepository<KnowledgeOfLanguage> asyncRepository,
		IMapper mapper)
	{
		_asyncRepository = asyncRepository;
		_mapper = mapper;
	}

	public async Task<KnowledgeOfLanguageDTO> Handle(
		GetLanguageItemQuery request, 
		CancellationToken cancellationToken)
	{
		var result = await _asyncRepository.GetById(request.id);
		if (result is null)
		{
			throw new NotFoundException("Not found!");
		}

		return _mapper.Map<KnowledgeOfLanguageDTO>(result);	
	}
}