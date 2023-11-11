using AutoMapper;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries;
using RecruitmentManager.Application.Functions.Worker_Functions.Common;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.UpdateJobOffer;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetJobOfferDetailsToEdit;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Mapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
		CreateMap<Employee, WorkerViewDTO>()
			.ForMember(dest => dest.FullName, 
			   opt => opt.MapFrom(src => src.EmployeeData.FirstName + " " + src.EmployeeData.LastName))
			.ForMember(dest => dest.Role, 
			   opt => opt.MapFrom(src => MapRoleIdToRoleString(src.RoleId)))
				.ReverseMap();
		CreateMap<Candidate, CandidateViewDTO>()
			.ForMember(dest => dest.FullName, 
			opt => opt.MapFrom(src => src.CandidateData.FirstName + " " + src.CandidateData.LastName));
		
		CreateMap<Employee, EmployeeDataDto>()
			.ForMember(dest => dest.FirstName, o => o.MapFrom(src => src.EmployeeData.FirstName))
			.ForMember(dest => dest.LastName, o => o.MapFrom(src => src.EmployeeData.LastName))
			.ForMember(dest => dest.BirthDate, o => o.MapFrom(src => src.EmployeeData.BirthDate))
			.ForMember(dest => dest.PhoneNumber, o => o.MapFrom(src => src.EmployeeData.PhoneNumber))
			.ReverseMap();
		CreateMap<Employee, RecruiterDto>()
			.ForMember(dest => dest.FirstName, o => o.MapFrom(src => src.EmployeeData.FirstName))
			.ForMember(dest => dest.LastName, o => o.MapFrom(src => src.EmployeeData.LastName))
			.ReverseMap();

		CreateMap<RecruitmentStage, RecruitmentStageWithEmployeeDto>()
			.ForMember(dest => dest.FullName, opt => opt.MapFrom(src =>
				src.Employee.EmployeeData.FirstName + " " + src.Employee.EmployeeData.LastName));

		CreateMap<JobPosting, JobOffersWhereCandidateAppliedViewDto>()
			.ForMember(dest => dest.AddedDate, opt => opt.MapFrom(src =>
				src.JobApplications.Select(x => x.AddedDate).FirstOrDefault()))
			.ForMember(dest => dest.InterviewQualified, opt => opt.MapFrom(src =>
				src.JobApplications.Select(x => x.InterviewQualified).FirstOrDefault()));
		CreateMap<ExperienceDTO, Experience>().ReverseMap();
		CreateMap<KnowledgeOfLanguage, KnowledgeOfLanguageDTO>().ReverseMap();
		CreateMap<JobOfferDetailsToEditDto, JobPosting>().ReverseMap();
		CreateMap<RecruitmentStagesToEditDto, RecruitmentStage>().ReverseMap();
		CreateMap<UpdateJobOfferCommand, JobPosting>().ReverseMap();
		CreateMap<PagedList<Candidate>, PagedList<CandidateViewDTO>>();
		CreateMap<PagedList<Employee>, PagedList<WorkerViewDTO>>().ReverseMap();
		CreateMap<JobPosting, JobOffersViewDto>().ReverseMap();
		CreateMap<PagedList<JobPosting>, PagedList<JobOffersViewDto>>().ReverseMap();
		CreateMap<RecruitmentStagesDto,RecruitmentStage>().ReverseMap();
    }
	private string MapRoleIdToRoleString(int roleId)
	{
		var enumType = (Roles)roleId;
		switch(enumType)
		{
			case Roles.Admin:
				return "Administrator";
			case Roles.Recruiter:
				return "Rekruter";
			case Roles.Manager:
				return "Szef Działu Rekrutacji";
		}
		return "";
	}
}
