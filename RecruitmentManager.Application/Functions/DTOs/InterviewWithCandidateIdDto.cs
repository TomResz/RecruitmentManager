using System.Runtime;

namespace RecruitmentManager.Application.Functions.DTOs;

public class InterviewWithCandidateIdDto : InterviewDto
{
	public Guid CandidateId { get; set; }
}