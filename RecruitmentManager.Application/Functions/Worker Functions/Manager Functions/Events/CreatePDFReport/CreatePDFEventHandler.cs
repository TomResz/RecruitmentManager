using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfEvaluatedCandidates;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfSelectedCandidates;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetStatisticsOfJobPosting;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Services;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.CreatePDFReport;

internal sealed class CreatePDFEventHandler
	: IRequestHandler<CreatePDFEvent>
{
	private readonly IMediator _mediator;
	private readonly IPdfPrinter _pdfPrinter;
	private readonly IDbContext _dbContext;
	public CreatePDFEventHandler(
		IMediator mediator,
		IPdfPrinter pdfPrinter,
		IDbContext dbContext)
	{
		_mediator = mediator;
		_pdfPrinter = pdfPrinter;
		_dbContext = dbContext;
	}

	public async Task Handle(CreatePDFEvent request, CancellationToken cancellationToken)
	{
		var statisticsQuery = new GetStatisticsOfJobPostingQuery(request.JobPostingId);
		var statistics = await _mediator.Send(statisticsQuery);

		var evaluatedCandidatesQuery = new GetListOfEvaluatedCandidatesQuery(request.JobPostingId);
		var evaluatedCandidates = await _mediator.Send(evaluatedCandidatesQuery);

		var selectedCandidatesQuery = new GetListOfSelectedCandidatesQuery(request.JobPostingId);
		var selectedCandidates = await _mediator.Send(selectedCandidatesQuery);

		var jobPosting = await _dbContext.Get<JobPosting>()
			.Include(x=>x.RecruitmentStages)
			.FirstOrDefaultAsync(x=>x.Id == request.JobPostingId);	

		if(statistics is null ||
			evaluatedCandidates is null ||
			jobPosting is null)
		{
			throw new NotFoundException("Error!!!");
		}
		_pdfPrinter.Print(
			request.FullPath,
			statistics,
			evaluatedCandidates,
			jobPosting,
			selectedCandidates);
	}
}
