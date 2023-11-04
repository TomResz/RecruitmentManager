using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CompleteJobOffer;

public class CompleteJobOfferCommandHandler
	: IRequestHandler<CompleteJobOfferCommand>
{
	private readonly IAsyncRepository<JobPosting> _repository;

	public CompleteJobOfferCommandHandler(
		IAsyncRepository<JobPosting> repository)
	{
		_repository = repository;
	}

	public async Task Handle(
		CompleteJobOfferCommand request,
		CancellationToken cancellationToken)
	{
		var jobOffer = await _repository.GetById(request.jobPostingId);
		if (jobOffer is null)
			throw new ArgumentException("Nie znaleziono tej ofert :-( .");
		jobOffer.EndDate = DateTime.Now;
		await _repository.Update(jobOffer);
	}
}