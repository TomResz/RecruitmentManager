using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetSkillsList;

public class GetSkillsListQueryHandler 
	: IRequestHandler<GetSkillListQuery,List<SkillDTO>>
{
	private readonly IAsyncRepository<Skill> _skillRepository;
	private readonly IMapper _mapper;
	private readonly ICandidateSessionContext _candidateSessionContext;
	public GetSkillsListQueryHandler(IAsyncRepository<Skill> skillRepository, 
		IMapper mapper, 
		ICandidateSessionContext candidateSessionContext)
	{
		_skillRepository = skillRepository;
		_mapper = mapper;
		_candidateSessionContext = candidateSessionContext;
	}

	public async Task<List<SkillDTO>> Handle(GetSkillListQuery request, CancellationToken cancellationToken)
	{
		Guid id = request.CandidateId ?? (
			_candidateSessionContext.CandidateId ?? throw new BadRequestException("Incorrect id authorization!"));
		var list = await _skillRepository.GetListByPredicateAsync(x => x.CandidateId == id);
		return _mapper.Map<List<SkillDTO>>(list);
	}
}