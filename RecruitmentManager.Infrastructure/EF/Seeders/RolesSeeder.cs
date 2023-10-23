using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public class RolesSeeder
{
	private readonly RecruitmentManagerDbContext _context;

	public RolesSeeder(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public void Seed()
	{
		if(!_context.Roles.Any()) 
		{
			_context.Roles.AddRange(GetRoles());
			_context.SaveChanges();
		}
	}
	private static List<Role> GetRoles()
	{
		var roleList = new List<Role>();

		var recruiter = new Role
		{
			Id =1,
			Name = "Recruiter"
		};
		roleList.Add(recruiter);
		var admin = new Role
		{
			Id =2,
			Name = "Admin"
		};
		roleList.Add(admin);
		var manager = new Role
		{
			Id =3,
			Name = "Manager",
		};
		roleList.Add(manager);
		return roleList;
	}
}
