using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
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


	public async Task<Candidate?> GetFullWithPBData(Guid Id, CancellationToken cancellationToken = default)
	{
		return await _context
			.Candidates
			.Include(x => x.CandidateData)
			.Include(x => x.ProfilePicture)
			.FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
	}

	public async Task<List<Candidate>> GetByJobPostingId(Guid jobPostingId)
	{
		var candidates = await _context
			.JobApplications
			.AsQueryable()
			.AsNoTracking()
			.Where(x => x.JobPostingId == jobPostingId)
			.Include(x => x.JobPosting)
			.Include(x => x.Candidate)
			.ThenInclude(x => x.CandidateData)
			.Select(x => new Candidate
			{
				Id = x.CandidateId,
				CandidateData = x.Candidate.CandidateData,
				JobApplications = x.Candidate.JobApplications
					.Where(y => y.JobPostingId == jobPostingId)
					.ToList(),
				Email = x.Candidate.Email,
				PasswordHash = x.Candidate.PasswordHash,
			})
			.ToListAsync();

		return candidates;
	}

	public async Task<Candidate?> GetFullData(Guid CandidateId, CancellationToken cancellationToken = default)
	{
		return await _context
			.Candidates
			.Include(x => x.CandidateData)
			.FirstOrDefaultAsync(x => x.Id == CandidateId, cancellationToken: cancellationToken);
	}

	public async Task<Candidate?> GetByEmailAsync(string email)
	{
		return await _context
			.Candidates
			.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower());
	}

	public async Task<List<EvaluatedCandidateDto>> GetListByJobPostingsWithRating(Guid JobPostingId)
	{
		var weightedGradesQuery = await _context.CandidateRatings
			.Join(_context.Candidates, cr => cr.CandidateId, c => c.Id, (cr, c) => new { cr, c })
			.Join(_context.CandidateData, combined => combined.c.Id, cd => cd.CandidateId, (combined, cd) => new { combined.cr, combined.c, cd })
			.Join(_context.RecruitmentStages, combined => combined.cr.RecruitmentStageId, rs => rs.Id, (combined, rs) => new
			{
				combined.cr.CandidateId,
				combined.cr.Grade,
				rs.GradeWeight,
				rs.JobPostingId,
				FullName = combined.cd.FirstName + " " + combined.cd.LastName
			})
			.Where(wg => wg.Grade != null && wg.JobPostingId == JobPostingId)
			.ToListAsync();

		var averageGradesQuery = weightedGradesQuery
			.GroupBy(wg => new { wg.CandidateId, wg.FullName })
			.Select(grouped => new EvaluatedCandidateDto
			{
				CandidateId = grouped.Key.CandidateId,
				AverageGrade = (double)grouped.Sum(x => x.Grade.Value * x.GradeWeight) / (double)grouped.Sum(x => x.GradeWeight),
				FullName = grouped.Key.FullName
			})
			.OrderByDescending(x => x.AverageGrade)
			.ToList();

		return averageGradesQuery;
	}
}
