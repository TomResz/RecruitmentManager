using AutoMapper;
using RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Queries;
using RecruitmentManager.Application.Pagination;
using RecruitmentManager.Domain.Entities;
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
		CreateMap<PagedList<Candidate>, PagedList<CandidateViewDTO>>();
		CreateMap<PagedList<Employee>, PagedList<WorkerViewDTO>>().ReverseMap();
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
