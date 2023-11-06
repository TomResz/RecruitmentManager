using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Infrastructure.EF.Context;

namespace RecruitmentManager.Infrastructure.EF.Repositories;

public class CandidateRepository : AsyncRepository<Candidate>, ICandidateRepository
{
	private readonly RecruitmentManagerDbContext _context;
	public CandidateRepository(RecruitmentManagerDbContext context) 
		: base(context)
	{
		_context = context;
	}


	public async Task<Candidate?> GetFullData(Guid Id, CancellationToken cancellationToken = default)
	{
		return await _context
			.Candidates
			.Include(x => x.CandidateData)
			.Include(x => x.ProfilePicture)
			.FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
	}
	public async Task<Candidate?> GetByEmailAsync(string email)
	{
		return await _context
			.Candidates
			.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower());
	}
}
