using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;
using RecruitmentManager.Infrastructure.EF.Seeders.Interface;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public class LanguageProficiencySeeder : IAsyncDbSeeder
{
	private readonly RecruitmentManagerDbContext _context;

	public LanguageProficiencySeeder(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task Seed()
	{
		if (!_context.LanguageProficiencies.Any())
		{
			await _context.AddRangeAsync(Get());
			await _context.SaveChangesAsync();
		}
	}

	private static List<LanguageProficiencyLevel> Get()
	{
		var list = new List<LanguageProficiencyLevel>();

		list.Add(new LanguageProficiencyLevel()
		{
			Id = 1,
			Level="A1"
		});
		list.Add(new LanguageProficiencyLevel()
		{
			Id = 2,
			Level = "A2"
		});
		list.Add(new LanguageProficiencyLevel()
		{
			Id = 3,
			Level = "B1"
		});
		list.Add(new LanguageProficiencyLevel()
		{
			Id = 4,
			Level = "B2"
		});
		list.Add(new LanguageProficiencyLevel()
		{
			Id = 5,
			Level = "C1"
		});
		list.Add(new LanguageProficiencyLevel()
		{
			Id = 6,
			Level = "C2"
		});
		return list;
	}
}
