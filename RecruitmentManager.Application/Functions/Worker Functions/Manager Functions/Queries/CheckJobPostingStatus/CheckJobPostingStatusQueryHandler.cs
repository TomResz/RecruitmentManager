using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.CheckJobPostingStatus;

public class CheckJobPostingStatusQueryHandler 
	: IRequestHandler<CheckJobPostingStatusQuery,bool>
{
	private readonly IJobPostingRepository _jobPostingRepository;

	public CheckJobPostingStatusQueryHandler(IJobPostingRepository jobPostingRepository)
	{
		_jobPostingRepository = jobPostingRepository;
	}

	public async Task<bool> Handle(CheckJobPostingStatusQuery request, CancellationToken cancellationToken)
	{
		var jobPosting = await _jobPostingRepository.GetById(request.JobPostingId);
		if (jobPosting is null)
		{
			throw new NotFoundException("Job posting not found!");
		}
		return jobPosting.IsCompleted;
	}
}