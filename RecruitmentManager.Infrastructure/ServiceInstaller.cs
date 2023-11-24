using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Infrastructure.Services.Candidate;
using RecruitmentManager.Infrastructure.Services.Common;

namespace RecruitmentManager.Infrastructure;

internal static class ServiceInstaller
{
	public static IServiceCollection AddServicesCollection(this IServiceCollection services)
	{
		services.AddSingleton<ICandidateSessionContext, CandidateSessionContext>();
		services.AddSingleton<IWorkerSessionContext, WorkerSessionContext>();
		services.AddSingleton<IUserBasicDataContext, UserBasicDataContext>();
		services.AddSingleton<IJobOfferContext, JobOfferContext>();
		services.AddSingleton<ICandidateContext, CandidateContext>();
		services.AddSingleton<IAssessmentCandidate, AssessmentCandidate>();
		return services;
	}
}