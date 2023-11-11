using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class EducationRepository : AsyncRepository<Education>, IEducationRepository 
{
	private readonly RecruitmentManagerDbContext _context;
	public EducationRepository(RecruitmentManagerDbContext context) : base(context)
	{
		_context = context;
	}

	public async Task<List<Education>> GetEducationListByCandidateId(Guid CandidateId)
	{
		return await _context
			.Education
			.Where(x => x.CandidateId == CandidateId)
			.ToListAsync();
	}
}