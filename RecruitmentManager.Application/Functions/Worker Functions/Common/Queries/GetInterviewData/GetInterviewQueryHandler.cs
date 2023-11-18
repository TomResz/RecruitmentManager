using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries.GetInterviewData;

public class GetInterviewQueryHandler 
	: IRequestHandler<GetInterviewDataQuery,List<InterviewDto>>
{
	private readonly ICandidateRatingRepository _candidateRepository;
	private readonly IWorkerSessionContext _workerSessionContext;

	public GetInterviewQueryHandler(ICandidateRatingRepository candidateRepository, 
		IWorkerSessionContext workerSessionContext)
	{
		_candidateRepository = candidateRepository;
		_workerSessionContext = workerSessionContext;
	}

	public async Task<List<InterviewDto>> Handle(GetInterviewDataQuery request, CancellationToken cancellationToken)
	{
		var id = _workerSessionContext.WorkerId ?? throw new BadRequestException("Unknown worker ID!");
		var list = await _candidateRepository.GetSetInterviewByRecruiterId(id);
		if (request.Actual)
		{
			var actualDate = DateTime.Today.Date;
			list = list.Where(x => x.InterviewDate != null
			                                 && x.InterviewDate.Value.Date >= actualDate)
				.ToList();
		}
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