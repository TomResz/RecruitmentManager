using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries;

public class GetEmployeeDataQueryHandler
	: IRequestHandler<GetEmployeeDataQuery,EmployeeDataDto>
{
	private readonly IEmployeeRepository _repository;
	private readonly IMapper _mapper;

	public GetEmployeeDataQueryHandler(
		IEmployeeRepository repository,
		IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<EmployeeDataDto> Handle(
		GetEmployeeDataQuery request, 
		CancellationToken cancellationToken)
	{
		var employee = await _repository.GetByIdFullDataAsync(request.Id);
		if( employee is null)
		{
			throw new InvalidDataException(
				"Nie znaleziono takiego użytkownika!");
		}
		var mapped= _mapper.Map<EmployeeDataDto>(employee);
		return mapped;
	}
}
