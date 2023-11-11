using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetSkillItem;

public class GetSkillItemQueryHandler
	: IRequestHandler<GetSkillItemQuery,SkillDTO>
{
	private readonly IAsyncRepository<Skill> _skillRepository;
	private readonly IMapper _mapper;
	public GetSkillItemQueryHandler(IAsyncRepository<Skill> skillRepository, IMapper mapper)
	{
		_skillRepository = skillRepository;
		_mapper = mapper;
	}

	public async Task<SkillDTO> Handle(
		GetSkillItemQuery request, 
		CancellationToken cancellationToken)
	{
		var skill = await _skillRepository.GetById(request.SkillId);
		if (skill is null)
		{
			throw new NotFoundException("Unknown entity!");
		}
		return _mapper.Map<SkillDTO>(skill);
	}
}