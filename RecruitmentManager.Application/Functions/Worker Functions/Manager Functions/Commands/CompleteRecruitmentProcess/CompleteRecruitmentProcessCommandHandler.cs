using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CompleteRecruitmentProcess;

internal class CompleteRecruitmentProcessCommandHandler
	: IRequestHandler<CompleteRecruitmentProcessCommand>
{
	private readonly IJobPostingRepository _jobPostingRepository;
	private readonly IMediator _mediator;

	public CompleteRecruitmentProcessCommandHandler(IJobPostingRepository jobPostingRepository, IMediator mediator)
	{
		_jobPostingRepository = jobPostingRepository;
		_mediator = mediator;
	}

	public async Task Handle(CompleteRecruitmentProcessCommand request, CancellationToken cancellationToken)
	{
		var jobPosting = await _jobPostingRepository.GetById(request.JobPostingId);
		if(jobPosting is null)
		{
			throw new NotFoundException(nameof(jobPosting));
		}
		jobPosting.IsCompleted = true;

		await _jobPostingRepository.Update(jobPosting);
	}
}
