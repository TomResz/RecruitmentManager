using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetHobbiesList;

public class GetHobbiesListQueryHandler
	: IRequestHandler<GetHobbiesListQuery,List<HobbyDTO>>
{
	private readonly IHobbyRepository _hobbyRepository;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IMapper _mapper;
	public GetHobbiesListQueryHandler(IHobbyRepository hobbyRepository, 
		ICandidateSessionContext candidateSessionContext, IMapper mapper)
	{
		_hobbyRepository = hobbyRepository;
		_candidateSessionContext = candidateSessionContext;
		_mapper = mapper;
	}

	public async Task<List<HobbyDTO>> Handle(GetHobbiesListQuery request, CancellationToken cancellationToken)
	{
		var candidateId= request.CandidateId ?? 
		                 (_candidateSessionContext.CandidateId 
		                  ?? throw new NotFoundException("Candidate session errors!"));

		var result = await _hobbyRepository.GetAllByCandidateId(candidateId);
		return _mapper.Map<List<HobbyDTO>>(result);
	}
}