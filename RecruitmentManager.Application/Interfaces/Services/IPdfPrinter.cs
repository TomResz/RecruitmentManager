using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfSelectedCandidates;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetStatisticsOfJobPosting;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Services;

public interface IPdfPrinter
{
	void Print(string fullPath, StatisticsOfJobPostingResponse statistics, 
		List<EvaluatedCandidateDto> candidates,JobPosting jobPosting,
		List<CandidateResponse> candidateResponses);	
}
