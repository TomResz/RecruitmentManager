using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetSetInterviews;

public class GetSetInterviewsQueryHandler
	: IRequestHandler<GetSetInterviewsQuery,List<InterviewDto>>
{
	private readonly ICandidateRatingRepository _candidateRatingRepository;

	public GetSetInterviewsQueryHandler(ICandidateRatingRepository candidateRatingRepository)
	{
		_candidateRatingRepository = candidateRatingRepository;
	}

	public async Task<List<InterviewDto>> Handle(GetSetInterviewsQuery request, CancellationToken cancellationToken)
	{
		var list = await _candidateRatingRepository.GetAllWithDate();
		list = list.OrderBy(x => x.InterviewDate).ToList();
		return list.Select(x => new InterviewDto()
		{
			Id = x.Id,
			Date = x.InterviewDate,
			StageName = x.RecruitmentStage.StageName,
			CandidateFullName = x.Candidate.CandidateData.FirstName + ' ' + x.Candidate.CandidateData.LastName,
			JobTitle = x.RecruitmentStage.JobPosting.Title
		}).ToList();
	}
}