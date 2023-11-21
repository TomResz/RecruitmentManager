using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SetDateOfInterview;

public class SetDateOfInterviewCommandHandler : IRequestHandler<SetDateOfInterviewCommand>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;
	private readonly IErrorSerializer _errorSerializer;
	public SetDateOfInterviewCommandHandler(ICandidateRatingRepository candidateRatingRepository, IErrorSerializer errorSerializer)
	{
		_candidateRatingRepository = candidateRatingRepository;
		_errorSerializer = errorSerializer;
	}

	public async Task Handle(SetDateOfInterviewCommand request, CancellationToken cancellationToken)
	{
		var validation = new SetDateOfInterviewCommandValidation();
		var result = await validation.ValidateAsync(request, cancellationToken);
		if (!result.IsValid)
		{
			throw new BadRequestException(_errorSerializer.Serialize(result.Errors));
		}
		var entity = await _candidateRatingRepository.GetById(request.CandidateRatingId);
		if (entity is null)
		{
			throw new NotFoundException("Interview not found!");
		}

		entity.InterviewDate = request.Date;
		await _candidateRatingRepository.Update(entity);
	}
}