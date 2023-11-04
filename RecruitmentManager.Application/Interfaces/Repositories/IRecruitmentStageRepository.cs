using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IRecruitmentStageRepository
{
	Task<List<RecruitmentStage>> GetByJobPostingId(Guid jobPostingId);
}