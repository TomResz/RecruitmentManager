using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;

public class GetInterviewsByInterviewPredicateQueryHandler
	: IRequestHandler<GetInterviewsByInterviewPredicateQuery, List<InterviewDto>>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;
	private readonly IWorkerSessionContext _workerSessionContext;
	public GetInterviewsByInterviewPredicateQueryHandler(
		ICandidateRatingRepository candidateRatingRepository,
		IWorkerSessionContext workerSessionContext)
	{
		_candidateRatingRepository = candidateRatingRepository;
		_workerSessionContext = workerSessionContext;
	}

	public async Task<List<InterviewDto>> Handle(
		GetInterviewsByInterviewPredicateQuery request,
		CancellationToken cancellationToken)
	{
		var id = _workerSessionContext.WorkerId ??
				 throw new BadRequestException(nameof(_workerSessionContext.WorkerId));
		var interviews = await _candidateRatingRepository.GetByRecruiterId(id);

		var currentDate = DateTime.Now.Date;
		interviews = request.InterviewPredicate switch
		{
			InterviewPredicate.Current => interviews
				.Where(x => x.InterviewDate >= currentDate && x.InterviewDate <= currentDate.AddDays(8))
				.ToList(),
			InterviewPredicate.Future => interviews
				.Where(x => x.InterviewDate >= currentDate)
				.ToList(),
			InterviewPredicate.Today => interviews
				.Where(x => x.InterviewDate >= currentDate && x.InterviewDate <= currentDate.AddDays(1))
				.ToList(),
			InterviewPredicate.Past => interviews
				.Where(x => x.InterviewDate <= currentDate)
				.ToList(),
			_ => interviews
		};

		return interviews.Select(x => new InterviewDto()
		{
			Id = x.Id,
			Date = x.InterviewDate,
			StageName = x.RecruitmentStage.StageName,
			CandidateFullName = x.Candidate.CandidateData.FirstName + ' ' + x.Candidate.CandidateData.LastName,
			JobTitle = x.RecruitmentStage.JobPosting.Title
		}).ToList();
	}
}