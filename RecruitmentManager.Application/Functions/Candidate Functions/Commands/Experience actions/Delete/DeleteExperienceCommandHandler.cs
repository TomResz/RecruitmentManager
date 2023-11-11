using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Delete;

public class DeleteExperienceCommandHandler
	: IRequestHandler<DeleteExperienceCommand>
{
	private readonly IAsyncRepository<Experience> _experienceRepository;

	public DeleteExperienceCommandHandler(IAsyncRepository<Experience> experienceRepository)
	{
		_experienceRepository = experienceRepository;
	}

	public async Task Handle(DeleteExperienceCommand request, CancellationToken cancellationToken)
	{
		var experience = await _experienceRepository.GetById(request.ExperienceId);
		if (experience is null)
		{
			throw new NotFoundException("Not found this item!");
		}

		await _experienceRepository.Delete(experience);
	}
}