using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IRecruitmentStageRepository : IAsyncRepository<RecruitmentStage>
{
	Task<List<RecruitmentStage>> GetByJobPostingId(Guid jobPostingId);
}