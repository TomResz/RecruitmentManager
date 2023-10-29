using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class EmployeeRepository : AsyncRepository<Employee>	
	, IEmployeeRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public EmployeeRepository(RecruitmentManagerDbContext context)
		: base(context)
	{
		_context = context;
	}

	public async Task<Employee?> GetByEmailAsync(string email)
	{
		return await _context
			.Employees
			.Include(e=>e.EmployeeData)
			.FirstOrDefaultAsync(x=>x.Email.ToLower() ==  email.ToLower());
	}

	public async Task<Employee?> GetByIdFullDataAsync(Guid Id)
	{
		return await _context
			.Employees
			.Include(e=>e.EmployeeData)
			.FirstOrDefaultAsync(x=>x.Id == Id);
	}
}
