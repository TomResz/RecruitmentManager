using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Infrastructure.Services.Candidate;
using RecruitmentManager.Infrastructure.Services.Common;
using System.Net.Mail;
using System.Net;
using RecruitmentManager.Application.Interfaces.Services;

namespace RecruitmentManager.Infrastructure;

internal static class ServiceInstaller
{
	public static IServiceCollection AddServicesCollection(this IServiceCollection services)
	{
		var smtpClient = new SmtpClient("smtp.gmail.com")
		{
			Port = 587,
			Credentials = new NetworkCredential("dzial.rekrutacji.firmy.xyz@gmail.com", "cdzdyibfgimvsxqq"),
			EnableSsl = true,
		};
		services.AddSingleton(smtpClient);
		services.AddTransient<IEmailSender, EmailSender>();
		services.AddTransient<IMultipleEmailSender,MultipleEmailSender>();

		services.AddSingleton<ICandidateSessionContext, CandidateSessionContext>();
		services.AddSingleton<IWorkerSessionContext, WorkerSessionContext>();
		services.AddSingleton<IUserBasicDataContext, UserBasicDataContext>();
		services.AddSingleton<IJobOfferContext, JobOfferContext>();
		services.AddSingleton<ICandidateContext, CandidateContext>();
		services.AddSingleton<IAssessmentCandidate, AssessmentCandidate>();
		return services;
	}
}