using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Delete;

public class DeleteEducationCommandHandler : IRequestHandler<DeleteEducationCommand>
{
	private readonly IEducationRepository _educationRepository;

	public DeleteEducationCommandHandler(IEducationRepository educationRepository)
	{
		_educationRepository = educationRepository;
	}

	public async Task Handle(DeleteEducationCommand request, CancellationToken cancellationToken)
	{
		var entityToRemove = await _educationRepository.GetById(request.Id);
		if (entityToRemove is null)
		{
			throw new NotFoundException("Unknown entity!");
		}

		await _educationRepository.Delete(entityToRemove);
	}
}