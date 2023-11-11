using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Delete;

public class DeleteSkillCommandHandler : IRequestHandler<DeleteSkillCommand>
{
	private readonly IAsyncRepository<Skill> _skillRepository;

	public DeleteSkillCommandHandler(IAsyncRepository<Skill> skillRepository)
	{
		_skillRepository = skillRepository;
	}

	public async Task Handle(DeleteSkillCommand request, CancellationToken cancellationToken)
	{
		var entity = await _skillRepository.GetById(request.Id);
		if (entity is null)
		{
			throw new NotFoundException("Entity not found!");
		}
		await _skillRepository.Delete(entity);
	}
}