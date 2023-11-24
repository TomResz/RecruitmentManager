using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Commands.RateCandidate;

public class RateCandidateCommandHandler
	: IRequestHandler<RateCandidateCommand>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;

	public RateCandidateCommandHandler(ICandidateRatingRepository candidateRatingRepository)
	{
		_candidateRatingRepository = candidateRatingRepository;
	}

	public async Task Handle(RateCandidateCommand request, CancellationToken cancellationToken)
	{
		var candidateRating = await _candidateRatingRepository.GetById(request.CandidateRatingId);
		if (candidateRating is null)
		{
			throw new NotFoundException("Candidate rating hasn't been found!");
		}
		candidateRating.Notes = request.Notes;
		candidateRating.Grade = request.Grade;
		await _candidateRatingRepository.Update(candidateRating);
	}
}