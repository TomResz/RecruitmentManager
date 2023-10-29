using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Enums;
using RecruitmentManager.Infrastructure.EF.Context;
using RecruitmentManager.Infrastructure.EF.Seeders.Interface;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public class WorkersSeed : IAsyncDbSeeder
{
	private readonly RecruitmentManagerDbContext _context;
	public WorkersSeed(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task Seed()
	{
		var passwdHasher = new PasswordHasher<Employee>();
		if(_context.Database.CanConnect())
		{
			if(!_context.Employees.Any())
			{
				var admin = new Employee
				{
					Id = Guid.NewGuid(),
					Email = "admin@gmail.com",
					RoleId = (int)Roles.Admin,
					EmployeeData = new EmployeeData
					{
						FirstName = "Admin",
						LastName = "Adminowski"
					}
				};
				var hash = passwdHasher.HashPassword(admin, "adminadmin");
				admin.PasswordHash = hash;
				await _context.Employees.AddAsync(admin);	
				await _context.SaveChangesAsync();
			}
		}
	}
}
