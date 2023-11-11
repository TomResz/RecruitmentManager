using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Delete;

public class DeleteHobbyCommandHandler
	: IRequestHandler<DeleteHobbyCommand>
{
	private readonly IAsyncRepository<Hobby> _asyncRepository;

	public DeleteHobbyCommandHandler(IAsyncRepository<Hobby> asyncRepository)
	{
		_asyncRepository = asyncRepository;
	}

	public async Task Handle(DeleteHobbyCommand request, CancellationToken cancellationToken)
	{
		var elementToDelete = await _asyncRepository.GetById(request.HobbyId);
		if (elementToDelete is null)
		{
			throw new NotFoundException("Hobby not found!");
		}

		await _asyncRepository.Delete(elementToDelete);
	}
}