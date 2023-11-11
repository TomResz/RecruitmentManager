using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Update;

public class UpdateSkillCommandHandler
	: IRequestHandler<UpdateSkillCommand>
{
	private readonly IAsyncRepository<Skill> _skillRepository;

	public UpdateSkillCommandHandler(IAsyncRepository<Skill> skillRepository)
	{
		_skillRepository = skillRepository;
	}

	public async Task Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
	{
		if (string.IsNullOrEmpty(request.Description))
		{
			throw new BadRequestException("Nieprawidłowy opis!");
		}
		var entity = await _skillRepository.GetById(request.Id);
		if (entity is null)
		{
			throw new NotFoundException("Entity not found!");
		}
		entity.Description = request.Description;
		await _skillRepository.Update(entity);
	}
}