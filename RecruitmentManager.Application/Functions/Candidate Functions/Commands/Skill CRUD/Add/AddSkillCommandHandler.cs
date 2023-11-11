using MediatR;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Skill_CRUD.Add;

public class AddSkillCommandHandler
	: IRequestHandler<AddSkillCommand>
{
	private readonly IAsyncRepository<Skill> _skillRepository;
	private readonly ICandidateSessionContext _candidateSessionContext;
	public AddSkillCommandHandler(IAsyncRepository<Skill> skillRepository, 
		ICandidateSessionContext candidateSessionContext)
	{
		_skillRepository = skillRepository;
		_candidateSessionContext = candidateSessionContext;
	}

	public async Task Handle(AddSkillCommand request, CancellationToken cancellationToken)
	{
		if (string.IsNullOrEmpty(request.Description))
		{
			throw new BadRequestException("Nieprawidłowy opis!");
		}

		var candidateId = _candidateSessionContext.CandidateId ?? 
		                  throw new NotFoundException("Authorization error!");
		var skill = new Skill
		{
			CandidateId = candidateId,
			Id = Guid.NewGuid(),
			Description = request.Description
		};
		await _skillRepository.Add(skill);
	}
}