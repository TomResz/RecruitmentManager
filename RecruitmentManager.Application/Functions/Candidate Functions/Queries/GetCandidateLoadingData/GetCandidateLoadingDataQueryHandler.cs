using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Domain.Entities.Candidate_Elements;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetCandidateLoadingData;

public class GetCandidateLoadingDataQueryHandler
	: IRequestHandler<GetCandidateLoadingDataQuery,CandidateLoadingData>
{
	private readonly IDbContext _context;

	public GetCandidateLoadingDataQueryHandler(
		IDbContext context)
	{
		_context = context;
	}

	public async Task<CandidateLoadingData> Handle(
		GetCandidateLoadingDataQuery request,
		CancellationToken cancellationToken)
	{
		var response = await _context.Get<ProfilePicture>()
			.Include(x => x.Candidate)
			.ThenInclude(x => x.CandidateData)
			.Where(x => x.CandidateId == request.CandidateId)
			.FirstOrDefaultAsync(cancellationToken);
		if (response is null)
			throw new ArgumentException("Nie znaleziono użytkownika!");
		string fullName = response.Candidate.CandidateData.FirstName + " " + response.Candidate.CandidateData.LastName;
		return new(fullName,response.Image);
	}
}