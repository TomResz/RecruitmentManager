using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.EmailComponents.Templates;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Services;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SendEmailsToChooseCandidates;

internal sealed class SendEmailsToChosenCandidatesCommandHandler
	: IRequestHandler<SendEmailsToChosenCandidatesCommand>
{
	private readonly IDbContext _dbContext;
	private readonly IMultipleEmailSender _emailSender;
	public SendEmailsToChosenCandidatesCommandHandler(
		IDbContext dbContext,
		IMultipleEmailSender emailSender)
	{
		_dbContext = dbContext;
		_emailSender = emailSender;
	}

	public async Task Handle(SendEmailsToChosenCandidatesCommand request, CancellationToken cancellationToken)
	{
		var emails = await _dbContext.Get<Candidate>()
			.Where(x => request.CandidateIDs.Contains(x.Id))
			.Select(x=>x.Email)
			.AsNoTracking()
			.ToListAsync(cancellationToken);

		var jobPostingTitle = await _dbContext.Get<JobPosting>()
			.Where(x=>x.Id == request.JobPostingId)
			.Select(x => x.Title)
			.AsNoTracking()
			.FirstOrDefaultAsync(cancellationToken);

		if(emails.Count is 0 || jobPostingTitle is null)
		{
			return;
		}

		var template = new SelectToJobEmailTemplate();
		var templateContent = template.GetTemplate(jobPostingTitle);

		await Task.Run(() => _emailSender.SendEmailToManyRecipients(emails, 
			 "Zakończenie procesu rekrutacji",
				templateContent));
	}
}
