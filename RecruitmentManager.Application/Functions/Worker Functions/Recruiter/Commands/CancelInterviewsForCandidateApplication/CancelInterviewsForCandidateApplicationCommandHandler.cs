using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.RecruiterList;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Commands.CancelInterviewsForCandidateApplication;

public class CancelInterviewsForCandidateApplicationCommandHandler
	: IRequestHandler<CancelInterviewsForCandidateApplicationCommand>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;

	public CancelInterviewsForCandidateApplicationCommandHandler(ICandidateRatingRepository candidateRatingRepository)
	{
		_candidateRatingRepository = candidateRatingRepository;
	}

	public async Task Handle(CancelInterviewsForCandidateApplicationCommand request, CancellationToken cancellationToken)
	{
		var candidateRatings =
			await _candidateRatingRepository.GetRatingsForCandidateApplicationTask(request.CandidateRatingId,
				request.CandidateId);
		foreach (var candidateRating in candidateRatings)
		{
			candidateRating.HasResigned = true;
		}

		await _candidateRatingRepository.UpdateRange(candidateRatings);
	}
}