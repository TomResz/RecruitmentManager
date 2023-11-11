using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetEducationItem;

public class GetEducationItemQueryHandler
	: IRequestHandler<GetEducationItemQuery,EducationDTO>
{
	private readonly IEducationRepository _educationRepository;
	private readonly IMapper _mapper;

	public GetEducationItemQueryHandler(IEducationRepository educationRepository, IMapper mapper)
	{
		_educationRepository = educationRepository;
		_mapper = mapper;
	}

	public async Task<EducationDTO> Handle(GetEducationItemQuery request, 
		CancellationToken cancellationToken)
	{
		var item = await _educationRepository.GetById(request.EducationId);
		if (item is null)
		{
			throw new BadRequestException("Entity not found!");
		}

		return _mapper.Map<EducationDTO>(item);
	}
}