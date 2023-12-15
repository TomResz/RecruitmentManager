using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface ISelectedCandidatesToJobRepository
{
	Task Add(List<SelectedCandidatesToJob> selectedCandidatesToJobs);
	Task Remove(Guid JobPostingId);
}
