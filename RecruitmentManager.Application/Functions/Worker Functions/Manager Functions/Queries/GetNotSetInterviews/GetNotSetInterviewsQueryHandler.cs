using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetNotSetInterviews;

public class GetNotSetInterviewsQueryHandler 
		: IRequestHandler<GetNotSetInterviewsQuery,List<InterviewDto>>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;

	public GetNotSetInterviewsQueryHandler(ICandidateRatingRepository candidateRatingRepository)
	{
		_candidateRatingRepository = candidateRatingRepository;
	}

	public async Task<List<InterviewDto>> Handle(GetNotSetInterviewsQuery request, CancellationToken cancellationToken)
	{
		var list = await _candidateRatingRepository.GetNotSetInterview();
		return list.Select(x => new InterviewDto()
		{
			Id = x.Id,
			Date = x.InterviewDate,
			StageName = x.RecruitmentStage.StageName,
			JobTitle = x.RecruitmentStage.JobPosting.Title,
			CandidateFullName = x.Candidate.CandidateData.FirstName + " " + x.Candidate.CandidateData.LastName
		}).ToList();
	}
}