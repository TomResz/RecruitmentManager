using RecruitmentManager.Application.Functions.DTOs;

namespace RecruitmentManager.Application.Functions.Common.Queries.GetCandidateDataQuery;

public record GetCandidateDataResponse(
	CandidateBasicDataDTO Data,
	List<EducationDTO> Educations,
	List<ExperienceDTO> Experiences,
	List<SkillDTO> Skills,
	List<KnowledgeOfLanguageDTO> KnowledgeOfLanguages,
	List<HobbyDTO> Hobbies);