using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Delete;

public class DeleteLanguageCommandHandler
	: IRequestHandler<DeleteLanguageCommand>
{
	private readonly IAsyncRepository<KnowledgeOfLanguage> _asyncRepository;

	public DeleteLanguageCommandHandler(IAsyncRepository<KnowledgeOfLanguage> asyncRepository)
	{
		_asyncRepository = asyncRepository;
	}

	public async Task Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
	{
		var entity = await _asyncRepository.GetById(request.Id);
		if (entity is null)
		{
			throw new NotFoundException("Unknown entity!");
		}

		await _asyncRepository.Delete(entity);
	}
}