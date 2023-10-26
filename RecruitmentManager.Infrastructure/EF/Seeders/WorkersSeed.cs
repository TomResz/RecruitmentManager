using Microsoft.AspNetCore.Identity;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Enums;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public class WorkersSeed
{
	private readonly RecruitmentManagerDbContext _context;
	public WorkersSeed(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public void Seed()
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
				};
				var hash = passwdHasher.HashPassword(admin, "adminadmin");
				admin.PasswordHash = hash;
				_context.Employees.Add(admin);	
				_context.SaveChanges();
			}
		}
	}
}
