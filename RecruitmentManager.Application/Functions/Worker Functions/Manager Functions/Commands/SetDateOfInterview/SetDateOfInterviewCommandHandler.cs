using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SetDateOfInterview;

public class SetDateOfInterviewCommandHandler : IRequestHandler<SetDateOfInterviewCommand>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;

	public SetDateOfInterviewCommandHandler(ICandidateRatingRepository candidateRatingRepository)
	{
		_candidateRatingRepository = candidateRatingRepository;
	}

	public async Task Handle(SetDateOfInterviewCommand request, CancellationToken cancellationToken)
	{
		var entity = await _candidateRatingRepository.GetById(request.CandidateRatingId);
		if (entity is null)
		{
			throw new NotFoundException("Interview not found!");
		}

		entity.InterviewDate = request.Date;
		await _candidateRatingRepository.Update(entity);
	}
}