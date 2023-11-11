using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetExperienceItem;

public class GetExperienceItemQueryHandler : IRequestHandler<GetExperienceItemQuery,ExperienceDTO>
{
	private readonly IAsyncRepository<Experience> _experienceRepository;
	private readonly IMapper _mapper;

	public GetExperienceItemQueryHandler(IAsyncRepository<Experience> experienceRepository,
		IMapper mapper)
	{
		_experienceRepository = experienceRepository;
		_mapper = mapper;
	}

	public async Task<ExperienceDTO> Handle(GetExperienceItemQuery request, CancellationToken cancellationToken)
	{
		var item = await _experienceRepository.GetById(request.id);
		if (item is null)
			throw new NotFoundException(nameof(item));
		return _mapper.Map<ExperienceDTO>(item);
	}
}