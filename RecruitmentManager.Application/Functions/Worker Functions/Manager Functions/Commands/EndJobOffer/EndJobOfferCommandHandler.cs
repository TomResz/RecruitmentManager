using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.EndJobOffer;

internal sealed class EndJobOfferCommandHandler
	: IRequestHandler<EndJobOfferCommand>
{
	private readonly IAsyncRepository<JobPosting> _repository;

	public EndJobOfferCommandHandler(IAsyncRepository<JobPosting> repository)
	{
		_repository = repository;
	}

	public async Task Handle(EndJobOfferCommand request, CancellationToken cancellationToken)
	{
		var jobPosting = await _repository.GetById(request.JobPostingId);
		if (jobPosting is null)
		{
			throw new NotFoundException(nameof(jobPosting));
		}
		jobPosting.IsCandidatesSelected = true;
		await _repository.Update(jobPosting);
	}
}
