using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetHobbyItem;

public class GetHobbyItemQueryHandler
	: IRequestHandler<GetHobbyItemQuery,HobbyDTO>
{
	private readonly IAsyncRepository<Hobby> _hobbyRepository;
	private readonly IMapper _mapper;
	public GetHobbyItemQueryHandler(IAsyncRepository<Hobby> hobbyRepository, 
		IMapper mapper)
	{
		_hobbyRepository = hobbyRepository;
		_mapper = mapper;
	}

	public async Task<HobbyDTO> Handle(GetHobbyItemQuery request, CancellationToken cancellationToken)
	{
		var item = await _hobbyRepository.GetById(request.Id);
		if (item is null)
		{
			throw new NotFoundException("Not found!");
		}
		return _mapper.Map<HobbyDTO>(item);
	}
}