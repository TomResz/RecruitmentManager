using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class HobbyRepository : IHobbyRepository
{
	private readonly RecruitmentManagerDbContext _context;

	public HobbyRepository(RecruitmentManagerDbContext context)
	{
		_context = context;
	}

	public async Task<List<Hobby>> GetAllByCandidateId(Guid CandidateId)
	{
		return await _context
			.Hobbies
			.Where(x => x.CandidateId == CandidateId)
			.ToListAsync();
	}
}