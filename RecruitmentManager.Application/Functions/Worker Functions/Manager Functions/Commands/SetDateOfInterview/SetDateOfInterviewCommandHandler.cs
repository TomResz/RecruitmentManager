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
		var candidateRating = await _candidateRatingRepository.GetById(request.CandidateRatingId);
		if (candidateRating is null)
		{
			throw new NotFoundException("Interview not found!");
		}

		var mettingsExists = await _candidateRatingRepository.ExistsInterviewsForRecruiterDuringThisTime(candidateRating, request.Date);
		if (mettingsExists)
		{
			throw new BadRequestException("Istnieją spotkania dla rekrutera w tym czasie!");
		}

		var interviewExists = await _candidateRatingRepository.ExistsInterviewsForCandidateDuringThisTime(candidateRating, request.Date);
		if (interviewExists)
		{
			throw new BadRequestException("Istnieją spotkania dla kandydata w tym czasie!");
		}
		candidateRating.InterviewDate = request.Date;
		await _candidateRatingRepository.Update(candidateRating);
	}
}