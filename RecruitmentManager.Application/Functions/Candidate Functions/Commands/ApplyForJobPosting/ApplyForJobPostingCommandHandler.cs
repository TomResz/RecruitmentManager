using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using System.Data;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.ApplyForJobPosting;

public class ApplyForJobPostingCommandHandler
	: IRequestHandler<ApplyForJobPostingCommand>
{
	private readonly IJobApplicationRepository _jobApplicationRepository;
	public ApplyForJobPostingCommandHandler(
		IJobApplicationRepository jobApplicationRepository)
	{
		_jobApplicationRepository = jobApplicationRepository;
	}

	public async Task Handle(
		ApplyForJobPostingCommand request,
		CancellationToken cancellationToken)
	{
		var exists = await _jobApplicationRepository.Exists(request.JobPostingId, request.CandidateId);
		if (exists)
		{
			throw new BadRequestException("Już aplikowałeś do tej oferty pracy!");
		}
		var date = DateTime.Now;
		var jobApplication = new JobApplication()
		{
			Id = Guid.NewGuid(),
			JobPostingId = request.JobPostingId,
			CandidateId = request.CandidateId,
			AddedDate = date
		};
		await _jobApplicationRepository.Add(jobApplication);
	}
}