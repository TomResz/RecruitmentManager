using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IEmployeeRepository : IAsyncRepository<Employee>
{
	Task<Employee?> GetByEmailAsync(string email);
	Task<Employee?> GetByIdFullDataAsync(Guid Id);
}
