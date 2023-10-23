using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Seeders;

public class LevelOfEducationSeeder
{
	private readonly RecruitmentManagerDbContext _context;

	public LevelOfEducationSeeder(RecruitmentManagerDbContext context)
	{
		_context = context;
	}
	
	public void Seed()
	{
		if (!_context.LevelOfEducations.Any())
		{
			_context.LevelOfEducations.AddRange(Get());
			_context.SaveChanges();
		}
	}
	private static List<LevelOfEducation> Get()
	{
		var list = new List<LevelOfEducation>();
		list.Add(new LevelOfEducation()
		{
			Id= 1,
			Name = "Primary"
		});
		list.Add(new LevelOfEducation()
		{
			Id = 2,
			Name = "Secondary"
		}); 
		list.Add(new LevelOfEducation()
		{
			Id = 3,
			Name = "Higher"
		});

		return list;
	}
}
