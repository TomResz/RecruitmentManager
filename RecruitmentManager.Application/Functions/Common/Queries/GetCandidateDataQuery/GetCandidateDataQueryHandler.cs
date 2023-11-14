using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetCandidateDataQuery;

public class GetCandidateDataQueryHandler
	: IRequestHandler<GetCandidateDataQuery, GetCandidateDataResponse>
{
	private readonly IMapper _mapper;
	private readonly IExperienceRepository _experienceRepository;
	private readonly IEducationRepository _educationRepository;
	private readonly IHobbyRepository _hobbyRepository;
	private readonly ICandidateRepository _candidateRepository;
	private readonly IKnowledgeOfLanguageRepository _knowledgeOfLanguageRepository;
	private readonly ISkillRepository _skillRepository;

	public GetCandidateDataQueryHandler(
		IExperienceRepository experienceRepository,
		IMapper mapper,
		IEducationRepository educationRepository,
		IHobbyRepository hobbyRepository,
		ICandidateRepository candidateRepository,
		IKnowledgeOfLanguageRepository knowledgeOfLanguageRepository,
		ISkillRepository skillRepository)
	{
		_experienceRepository = experienceRepository;
		_mapper = mapper;
		_educationRepository = educationRepository;
		_hobbyRepository = hobbyRepository;
		_candidateRepository = candidateRepository;
		_knowledgeOfLanguageRepository = knowledgeOfLanguageRepository;
		_skillRepository = skillRepository;
	}

	public async Task<GetCandidateDataResponse> Handle(
		GetCandidateDataQuery request,
		CancellationToken cancellationToken)
	{
		var candidate = await _candidateRepository.GetFullData(request.CandidateId, cancellationToken);
		if (candidate is null)
			throw new NotFoundException(nameof(candidate));
		var candidateData = new CandidateBasicDataDTO(
			id: candidate.Id,
			firstName: candidate.CandidateData.FirstName,
			lastName: candidate.CandidateData.LastName,
			picture: candidate.ProfilePicture.Image,
			phoneNumber: candidate.CandidateData.PhoneNumber,
			email: candidate.Email,
			city: candidate.CandidateData.City,
			dateOfBirth: candidate.CandidateData.BirthDate);

		var experiences = _mapper.Map<List<ExperienceDTO>>(
			await _experienceRepository.GetByCandidateIdWithoutTracking(request.CandidateId, cancellationToken));
		var educations =
			_mapper.Map<List<EducationDTO>>(
				await _educationRepository.GetEducationListByCandidateId(request.CandidateId));
		var hobbies = _mapper.Map<List<HobbyDTO>>(
			await _hobbyRepository.GetAllByCandidateId(request.CandidateId));
		var languages = _mapper.Map<List<KnowledgeOfLanguageDTO>>(
			await _knowledgeOfLanguageRepository.GetAllByCandidateId(request.CandidateId));
		var skills = _mapper.Map<List<SkillDTO>>(
			await _skillRepository.GetByCandidateIdList(request.CandidateId));

		return new GetCandidateDataResponse(
			candidateData,
			educations,
			experiences,
			skills,
			languages,
			hobbies);
	}
}