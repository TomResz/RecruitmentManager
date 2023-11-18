using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Add;

public class AddHobbyCommandHandler : IRequestHandler<AddHobbyCommand>
{
	private readonly IAsyncRepository<Hobby> _hobbyRepository;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IErrorSerializer _errorSerializer;
	public AddHobbyCommandHandler(IAsyncRepository<Hobby> hobbyRepository, 
		ICandidateSessionContext candidateSessionContext, 
		IErrorSerializer errorSerializer)
	{
		_hobbyRepository = hobbyRepository;
		_candidateSessionContext = candidateSessionContext;
		_errorSerializer = errorSerializer;
	}

	public async Task Handle(AddHobbyCommand request, CancellationToken cancellationToken)
	{
		var validation = new AddHobbyCommandValidator();
		var resultOfVal = await validation.ValidateAsync(request, cancellationToken);
		if (!resultOfVal.IsValid)
		{
			throw new BadRequestException(_errorSerializer.Serialize(resultOfVal.Errors));
		}

		var candidateId = _candidateSessionContext.CandidateId ??
		                  throw new NotFoundException("Invalid user ID!");
		var hobby = new Hobby()
		{
			Id = Guid.NewGuid(),
			Description = request.Description,
			CandidateId = candidateId
		};
		await _hobbyRepository.Add(hobby);
	}
}