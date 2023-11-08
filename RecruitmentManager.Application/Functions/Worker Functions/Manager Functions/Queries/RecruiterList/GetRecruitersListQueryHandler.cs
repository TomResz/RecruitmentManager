using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.RecruiterList;

public class GetRecruitersListQueryHandler
	: IRequestHandler<GetRecruitersListQuery, List<RecruiterDto>>
{
	private readonly IEmployeeRepository _employeeRepository;
	private readonly IMapper _mapper;

	public GetRecruitersListQueryHandler(
		IEmployeeRepository employeeRepository,
		IMapper mapper)
	{
		_employeeRepository = employeeRepository;
		_mapper = mapper;
	}

	public async Task<List<RecruiterDto>> Handle(
		GetRecruitersListQuery request,
		CancellationToken cancellationToken)
	{
		var list = await _employeeRepository.GetEmployeesByRole(Roles.Recruiter);
		return _mapper.Map<List<RecruiterDto>>(list);
	}
}