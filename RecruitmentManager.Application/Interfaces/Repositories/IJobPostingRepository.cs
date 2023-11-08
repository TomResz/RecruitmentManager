using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IJobPostingRepository : IAsyncRepository<JobPosting>
{
	Task AddAsync(JobPosting entity);
	Task<JobPosting?> GetFullDataByIdAsync(Guid id);
	Task UpdateWithRecruitmentStage(JobPosting entity);
	Task<List<JobPosting>> GetWithJobApplicationWhereDidNotApply(Guid candidateId);
	Task<List<JobPosting>> GetWithJobApplicationWhereApply(Guid candidateId);
}