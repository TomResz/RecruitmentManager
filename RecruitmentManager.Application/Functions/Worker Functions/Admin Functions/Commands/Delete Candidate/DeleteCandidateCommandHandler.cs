using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Admin_Functions.Commands.Delete_Candidate;

public class DeleteCandidateCommandHandler
	: IRequestHandler<DeleteCandidateCommand>
{
	private readonly ICandidateRepository _repository;

	public DeleteCandidateCommandHandler(ICandidateRepository repository)
	{
		_repository = repository;
	}

	public async Task Handle(
		DeleteCandidateCommand request, 
		CancellationToken cancellationToken)
	{
		var candidate = await _repository.GetById(request.Id);
        if (candidate is null)
        {
			throw new NotFoundException("Nieprawidłowy ID!");
        }
		await _repository.Delete(candidate);
    }	
}
