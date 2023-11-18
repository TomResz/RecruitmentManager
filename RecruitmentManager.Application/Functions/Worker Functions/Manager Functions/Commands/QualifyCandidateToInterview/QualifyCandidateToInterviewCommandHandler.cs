using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.QualifyCandidateToInterview;

public class QualifyCandidateToInterviewCommandHandler
	: IRequestHandler<QualifyCandidateToInterviewCommand>
{
	private readonly IJobApplicationRepository _jobApplicationRepository;

	public QualifyCandidateToInterviewCommandHandler(
		IJobApplicationRepository jobApplicationRepository)
	{
		_jobApplicationRepository = jobApplicationRepository;
	}

	public async Task Handle(QualifyCandidateToInterviewCommand request,
		CancellationToken cancellationToken)
	{
		var applications = await _jobApplicationRepository.GetListByPredicateAsync(
			x => x.JobPostingId == request.JobPostingId &&
			   x.CandidateId == request.CandidateId);

		if (applications is null)
			throw new NotFoundException(nameof(request.JobPostingId));

		var jobApplication = applications
			.FirstOrDefault();
		if (jobApplication is null)
			throw new NotFoundException(nameof(request.CandidateId));
		if (jobApplication.InterviewQualified)
			throw new BadRequestException("Candidate is actually qualified!");
		jobApplication.InterviewQualified = true;
		await _jobApplicationRepository.Update(jobApplication);
	}
}