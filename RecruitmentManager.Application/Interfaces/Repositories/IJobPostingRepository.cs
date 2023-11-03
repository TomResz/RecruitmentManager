using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IJobPostingRepository
{
	Task AddAsync(JobPosting entity);
}