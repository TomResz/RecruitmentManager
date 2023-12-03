using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfEvaluatedCandidates;

internal class GetListOfEvaluatedCandidatesQueryHandler
	: IRequestHandler<GetListOfEvaluatedCandidatesQuery, List<EvaluatedCandidateDto>>
{
	private readonly ICandidateRepository _candidateRepository;
	public GetListOfEvaluatedCandidatesQueryHandler(
		ICandidateRepository candidateRepository)
	{
		_candidateRepository = candidateRepository;
	}


	public async Task<List<EvaluatedCandidateDto>> Handle(
		GetListOfEvaluatedCandidatesQuery request,
		CancellationToken cancellationToken)
	{
		var candidates = await _candidateRepository.GetListByJobPostingsWithRating(request.JobPostingId);
		var dtos = new List<EvaluatedCandidateDto>();
		foreach (var candidate in candidates)
		{
			var totlalWeightedGrade = candidate.CandidateRatings
				.Where(r => r.RecruitmentStage.JobPostingId == request.JobPostingId &&
					r.Grade.HasValue &&
					!r.HasResigned)
				.Sum(x => x.Grade * x.RecruitmentStage.GradeWeight);
			var totalWeight = candidate.CandidateRatings
				.Where(r => r.RecruitmentStage.JobPostingId == request.JobPostingId &&
					r.Grade.HasValue &&
					!r.HasResigned)
				.Sum(x => x.RecruitmentStage.GradeWeight);

			dtos.Add(new EvaluatedCandidateDto
			{
				CandidateId = candidate.Id,
				AverageGrade = (totlalWeightedGrade / (double)totalWeight) ?? 0.0,
				FullName = $"{candidate.CandidateData.FirstName} {candidate.CandidateData.LastName}"
			});
		}

		var sortedDtos = dtos
			.OrderByDescending(x => x.AverageGrade)
			.ToList();
		
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
