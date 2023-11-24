using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateInterviews;

public class GetCandidateInterviewsQueryHandler :
	IRequestHandler<GetCandidateInterviewsQuery, List<InterviewDto>>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;
	private readonly ICandidateSessionContext _candidateSessionContext;
	public GetCandidateInterviewsQueryHandler(ICandidateRatingRepository candidateRatingRepository, ICandidateSessionContext candidateSessionContext)
	{
		_candidateRatingRepository = candidateRatingRepository;
		_candidateSessionContext = candidateSessionContext;
	}

	public async Task<List<InterviewDto>> Handle(GetCandidateInterviewsQuery request, CancellationToken cancellationToken)
	{
		var candidateId = _candidateSessionContext.CandidateId ?? throw new NotFoundException(nameof(
			_candidateSessionContext.CandidateId));
		var ratings = await _candidateRatingRepository.GetFullDataByCandidateId(candidateId);
		var currentDate = DateTime.Now;
		var list = request.InterviewPredicate switch
		{
			CandidateInterviewPredicate.Current => ratings
				.Where(x => x.InterviewDate <= currentDate.AddDays(2) 
				            && x.InterviewDate >= currentDate.AddDays(-2) && 
				            x.HasResigned == false ).ToList(),
			CandidateInterviewPredicate.Past => ratings
				.Where(x => x.InterviewDate <= currentDate.AddDays(-2)).ToList(),
			_ => ratings
		};

		return list.Select(x => new InterviewDto()
		{
			Id = x.Id,
			Date = x.InterviewDate,
			StageName = x.RecruitmentStage.StageName,
			CandidateFullName = x.Candidate.CandidateData.FirstName + ' ' + x.Candidate.CandidateData.LastName,
			JobTitle = x.RecruitmentStage.JobPosting.Title,
			HasResigned = x.HasResigned,
		}).ToList();
	}
}