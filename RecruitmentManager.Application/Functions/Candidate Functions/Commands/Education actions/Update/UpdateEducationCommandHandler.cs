using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Update;

public class UpdateEducationCommandHandler
	: IRequestHandler<UpdateEducationCommand>
{
	private readonly IEducationRepository _repository;

	public UpdateEducationCommandHandler(IEducationRepository repository)
	{
		_repository = repository;
	}

	public async Task Handle(UpdateEducationCommand request, CancellationToken cancellationToken)
	{
		var entityToUpdate = await _repository.GetById(request.Id);
		if (entityToUpdate is null)
		{
			throw new NotFoundException("Entity not found!");
		}
		entityToUpdate.DateOfCompletion = request.End;
		entityToUpdate.SchoolName = request.SchoolName;
		entityToUpdate.Major = request.Major;
		entityToUpdate.IsCompleted = request.End is not null;
		entityToUpdate.DateOfCompletion = request.End;
		entityToUpdate.LevelOfEducationId = request.LevelOfEducationId;
		await _repository.Update(entityToUpdate);
	}
}