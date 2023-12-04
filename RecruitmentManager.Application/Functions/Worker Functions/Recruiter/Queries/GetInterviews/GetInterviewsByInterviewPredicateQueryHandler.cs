using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Recruiter.Queries.GetInterviews;

public class GetInterviewsByInterviewPredicateQueryHandler
	: IRequestHandler<GetInterviewsByInterviewPredicateQuery, List<InterviewWithCandidateIdDto>>
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

	public async Task<List<InterviewWithCandidateIdDto>> Handle(
		GetInterviewsByInterviewPredicateQuery request,
		CancellationToken cancellationToken)
	{
		var id = _workerSessionContext.WorkerId ??
				 throw new BadRequestException(nameof(_workerSessionContext.WorkerId));
		var interviews = await _candidateRatingRepository.GetByRecruiterId(id);
		interviews = interviews
			.Where(x => !x.HasResigned)
			.ToList();
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
			InterviewPredicate.TwoDays => interviews
				.Where(x=>x.InterviewDate >= currentDate.AddDays(-2) && x.InterviewDate <= currentDate.AddDays(2))
				.ToList(),
			InterviewPredicate.All => interviews
				.Where(x=>x.Grade == null)
				.ToList(),
			_ => interviews
		};

		return interviews.Select(x => new InterviewWithCandidateIdDto()
		{
			Id = x.Id,
			Date = x.InterviewDate,
			StageName = x.RecruitmentStage.StageName,
			CandidateFullName = $"{x.Candidate.CandidateData.FirstName} {x.Candidate.CandidateData.LastName}",
			JobTitle = x.RecruitmentStage.JobPosting.Title,
			CandidateId = x.CandidateId,
		}).OrderBy(x=>x.Date).ToList();
	}
}