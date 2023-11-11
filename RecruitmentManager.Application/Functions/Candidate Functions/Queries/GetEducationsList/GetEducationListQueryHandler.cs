using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetEducationsList;

public class GetEducationListQueryHandler
	: IRequestHandler<GetEducationListQuery,List<EducationDTO>>
{
	private readonly IEducationRepository _educationRepository;
	private readonly IMapper _mapper;
	private readonly ICandidateSessionContext _candidateSessionContext;
	public GetEducationListQueryHandler(
		IEducationRepository educationRepository, 
		IMapper mapper,
		ICandidateSessionContext candidateSessionContext)
	{
		_educationRepository = educationRepository;
		_mapper = mapper;
		_candidateSessionContext = candidateSessionContext;
	}

	public async Task<List<EducationDTO>> Handle(GetEducationListQuery request, CancellationToken cancellationToken)
	{
		var id = request.CandidateId ?? (
			_candidateSessionContext.CandidateId ??
			throw new BadRequestException("Unhandled authorization error!"));
		var list = await _educationRepository.GetEducationListByCandidateId(id);
		return _mapper.Map<List<EducationDTO>>(list);	
	}
}