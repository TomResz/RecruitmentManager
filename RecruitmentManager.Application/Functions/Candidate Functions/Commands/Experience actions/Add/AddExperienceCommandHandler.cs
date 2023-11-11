using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Add;

public class AddExperienceCommandHandler
	: IRequestHandler<AddExperienceCommand>
{
	private readonly IAsyncRepository<Experience> _repository;
	private readonly ICandidateSessionContext _candidateSessionContext;

	public AddExperienceCommandHandler(
		IAsyncRepository<Experience> repository,
		ICandidateSessionContext candidateSessionContext)
	{
		_repository = repository;
		_candidateSessionContext = candidateSessionContext;
	}

	public async Task Handle(AddExperienceCommand request,
		CancellationToken cancellationToken)
	{
		var validation = new AddExperienceCommandValidation();
		var result = await validation.ValidateAsync(request, cancellationToken);
		if (!result.IsValid)
		{
			throw new BadRequestException(FVErrorSerializer.SerializeToString(result.Errors));
		}

		var candidateId = _candidateSessionContext.CandidateId 
		                  ?? throw new NotFoundException("");
		var experienceEntity = new Experience()
		{
			Id = Guid.NewGuid(),
			CandidateId = candidateId,
			CompanyName = request.CompanyName,
			OfCompletionOfWork = request.End,
			JobName = request.Title,
			Description = request.Description,
			StartDateOfWork = request.Start
		};
		await _repository.Add(experienceEntity);
	}
}