using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Add;

public class AddLanguageCommandHandler
	: IRequestHandler<AddLanguageCommand>
{
	private readonly IAsyncRepository<KnowledgeOfLanguage> _asyncRepository;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IErrorSerializer _errorSerializer;
	public AddLanguageCommandHandler(IAsyncRepository<KnowledgeOfLanguage> asyncRepository, ICandidateSessionContext candidateSessionContext, IErrorSerializer errorSerializer)
	{
		_asyncRepository = asyncRepository;
		_candidateSessionContext = candidateSessionContext;
		_errorSerializer = errorSerializer;
	}

	public async Task Handle(AddLanguageCommand request, CancellationToken cancellationToken)
	{
		var validation = new AddLanguageCommandValidation();
		var result = await validation.ValidateAsync(request, cancellationToken);
		if (!result.IsValid)
		{
			throw new BadRequestException(_errorSerializer.Serialize(result.Errors));
		}

		var candidateId = _candidateSessionContext.CandidateId 
		                  ?? throw new BadRequestException("Unknown candidate!"); 
		var languageEntity = new KnowledgeOfLanguage
		{
			Id = Guid.NewGuid(),
			CandidateId	= candidateId,
			Language = request.Language,
			LanguageProficiencyLevelId = (int)request.LanguageLevel
		};
		await _asyncRepository.Add(languageEntity);
	}
}