using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public class MainSeeder
{
	private readonly RecruitmentManagerDbContext _context;
	private readonly RolesSeeder _rolesSeeder;
	private readonly LanguageProficiencySeeder _languageProficiencySeeder;
	private readonly LevelOfEducationSeeder _levelOfEducationSeeder;



	public MainSeeder(RecruitmentManagerDbContext context)
	{
		_context = context;
		_rolesSeeder = new RolesSeeder(context);
		_languageProficiencySeeder = new LanguageProficiencySeeder(context);
		_levelOfEducationSeeder = new LevelOfEducationSeeder(context);
	}

	public void Initialize()
	{
		_rolesSeeder.Seed();
		_levelOfEducationSeeder.Seed();
		_languageProficiencySeeder.Seed();
	}
}
