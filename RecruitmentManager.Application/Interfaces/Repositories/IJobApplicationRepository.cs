using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IJobApplicationRepository
{
	Task<bool> Exists(Guid jobPostingId, Guid candidateId);

	Task Add(JobApplication jobApplication);
}