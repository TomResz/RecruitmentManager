using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfEvaluatedCandidates;

internal class GetListOfEvaluatedCandidatesQueryHandler
	: IRequestHandler<GetListOfEvaluatedCandidatesQuery, List<EvaluatedCandidateDto>>
{
	private readonly ICandidateRepository _candidateRepository;
	public GetListOfEvaluatedCandidatesQueryHandler(ICandidateRepository candidateRepository)
	{
		_candidateRepository = candidateRepository;
	}


	public async Task<List<EvaluatedCandidateDto>> Handle(
		GetListOfEvaluatedCandidatesQuery request,
		CancellationToken cancellationToken)
	{
		var sortedDtos = await _candidateRepository.GetListByJobPostingsWithRating(request.JobPostingId);
		for(int i=0; i<sortedDtos.Count;i++)
		{
			if(i > 0 && (sortedDtos[i-1].AverageGrade == sortedDtos[i].AverageGrade))
			{
				sortedDtos[i].Position = sortedDtos[i - 1].Position;
				continue;
			}
			sortedDtos[i].Position = i + 1;
		}
		return sortedDtos;
	}
}
