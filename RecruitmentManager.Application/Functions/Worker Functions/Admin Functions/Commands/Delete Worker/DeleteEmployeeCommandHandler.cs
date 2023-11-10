using MediatR;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.Delete_Worker;

public class DeleteEmployeeCommandHandler
	: IRequestHandler<DeleteEmployeeCommand>
{
	private readonly IEmployeeRepository _repository;
	private readonly IWorkerSessionContext _sessionContext;
	public DeleteEmployeeCommandHandler(
		IEmployeeRepository repository,
		IWorkerSessionContext sessionContext)
	{
		_repository = repository;
		_sessionContext = sessionContext;
	}

	public async Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
	{
		if(request.Id == _sessionContext.WorkerId)
		{
			throw new BadRequestException("Nie można siebie samego usunąć :-(\r\n😢😢😢");
		}
		var entity = await _repository.GetById(request.Id);
		if(entity is null)
		{
			throw new NotFoundException("Nieznany błąd!");
		}
		await _repository.Delete(entity);
	}
}
