using System.Security.AccessControl;

namespace RecruitmentManager.Application.Functions.DTOs;

public class CandidateDTO
{
	public Guid Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
}