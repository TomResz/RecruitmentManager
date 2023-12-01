using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Shared.Exceptions;
using System.Xml;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfEvaluatedCandidates;

internal class GetListOfEvaluatedCandidatesQueryHandler
	: IRequestHandler<GetListOfEvaluatedCandidatesQuery, List<EvaluatedCandidateDto>>
{
	private readonly ICandidateRepository _candidateRepository;
	private readonly IJobPostingRepository _jobPostingRepository;
	public GetListOfEvaluatedCandidatesQueryHandler(
		ICandidateRepository candidateRepository,
		IJobPostingRepository jobPostingRepository)
	{
		_candidateRepository = candidateRepository;
		_jobPostingRepository = jobPostingRepository;
	}


	public async Task<List<EvaluatedCandidateDto>> Handle(
		GetListOfEvaluatedCandidatesQuery request,
		CancellationToken cancellationToken)
	{
		var jobPosting = await _jobPostingRepository.GetById(request.JobPostingId);

		if(jobPosting is null)
		{
			throw new NotFoundException("Job posting not found!");
		}
		var positions = jobPosting.NumberOfPositions;

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
				AverageGrade = (totlalWeightedGrade / totalWeight) ?? 0.0,
				FullName = $"{candidate.CandidateData.FirstName} {candidate.CandidateData.LastName}"
			});
		}

		var sortedDtos = dtos.OrderByDescending(x=>x.AverageGrade).ToList();
		int i = 0;
		foreach(var dto in sortedDtos)
		{
			i++;
			if(i > 1 )
			{
				if(sortedDtos[i - 1].AverageGrade == dto.AverageGrade)
				{
					dto.Position = sortedDtos[i - 1].Position;
				}
				continue;
			}
			dto.Position = i;
		}

		return sortedDtos;
	}
}
