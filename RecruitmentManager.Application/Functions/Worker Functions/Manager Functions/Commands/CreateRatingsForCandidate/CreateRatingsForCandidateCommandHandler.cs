using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CreateRatingsForCandidate;

public class CreateRatingsForCandidateCommandHandler
	: IRequestHandler<CreateRatingsForCandidateCommand>
{
	private readonly IRecruitmentStageRepository _repository;
	private readonly ICandidateRatingRepository _candidateRatingRepository;

	public CreateRatingsForCandidateCommandHandler(
		IRecruitmentStageRepository repository, 
		ICandidateRatingRepository candidateRatingRepository)
	{
		_repository = repository;
		_candidateRatingRepository = candidateRatingRepository;
	}

	public async Task Handle(CreateRatingsForCandidateCommand request, CancellationToken cancellationToken)
	{
		var ratingCollection = new List<CandidateRating>();
		var list = await _repository.GetByJobPostingId(request.JobPostingId);
		foreach (var rating in list)
		{
			ratingCollection.Add(new CandidateRating()
			{
				Id = Guid.NewGuid(),
				RecruitmentStageId = rating.Id,
				CandidateId = request.CandidateId
			});
		}
		await _candidateRatingRepository.AddRange(ratingCollection);
	}
}