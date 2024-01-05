using MediatR;
using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Application.EmailComponents.Templates;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Services;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SendEmailOfRecruitmentStageInfo;

internal sealed class SendEmailOfRecruitmentStageInfoCommandHandler
	: IRequestHandler<SendEmailOfRecruitmentStageInfoCommand>
{
	private readonly IEmailSender _emailSender;
	private readonly IDbContext _dbContext;

	public SendEmailOfRecruitmentStageInfoCommandHandler(IEmailSender emailSender, IDbContext dbContext)
	{
		_emailSender = emailSender;
		_dbContext = dbContext;
	}

	public async Task Handle(SendEmailOfRecruitmentStageInfoCommand request, CancellationToken cancellationToken)
	{
		var data = await _dbContext.Get<CandidateRating>()
			.Include(x => x.Candidate)
			.Include(x => x.RecruitmentStage)
			.ThenInclude(x => x.JobPosting)
			.AsNoTracking()
			.FirstOrDefaultAsync(x => x.Id == request.CandidateRatingId);

		if (data is null)
		{
			throw new NotFoundException(nameof(data));
		}
		var email = data.Candidate.Email;
		var date = data.InterviewDate;
		var jobPostingName = data.RecruitmentStage.JobPosting.Title;
		var recruitmentStageName = data.RecruitmentStage.StageName;

		if(date is null)
		{
			throw new NotFoundException(nameof(date));
		}

		var emailTemplate = new InterviewDateEmailTemplate();
		var emailContent = emailTemplate.GetTemplate(jobPostingName,
			  recruitmentStageName, 
			   (DateTime)date);

		await _emailSender.SendEmail(email, "Rozmowa kwalifikacyjna-termin",
			emailContent);
	}
}
