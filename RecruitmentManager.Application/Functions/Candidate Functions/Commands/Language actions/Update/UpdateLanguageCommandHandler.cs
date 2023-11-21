using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Update;

public class UpdateLanguageCommandHandler
	: IRequestHandler<UpdateLanguageCommand>
{
	private readonly IAsyncRepository<KnowledgeOfLanguage> _asyncRepository;
	private readonly IErrorSerializer _errorSerializer;

	public UpdateLanguageCommandHandler(IAsyncRepository<KnowledgeOfLanguage> asyncRepository,
		IErrorSerializer errorSerializer)
	{
		_asyncRepository = asyncRepository;
		_errorSerializer = errorSerializer;
	}

	public async Task Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
	{
		var validation = new UpdateLanguageCommandValidator();
		var resultOfVal = await validation.ValidateAsync(request, cancellationToken);
		if (!resultOfVal.IsValid)
		{
			throw new BadRequestException(_errorSerializer.Serialize(resultOfVal.Errors));
		}
		var entity = await _asyncRepository.GetById(request.Id);
		if (entity is null)
		{
			throw new NotFoundException("Not found!");
		}
		entity.Language = request.Language;
		entity.LanguageProficiencyLevelId = (int)request.LanguageLevel;
		await _asyncRepository.Update(entity);
	}
}