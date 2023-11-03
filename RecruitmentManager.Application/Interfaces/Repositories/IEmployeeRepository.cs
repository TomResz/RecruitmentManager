using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Interfaces.Repositories;

public interface IEmployeeRepository : IAsyncRepository<Employee>
{
	Task<List<Employee>> GetEmployeesByRole(Roles role);
	Task<Employee?> GetByEmailAsync(string email);
	Task<Employee?> GetByIdFullDataAsync(Guid Id);
}
