using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Subtitles;
using System.Globalization;

namespace RecruitmentManager.DI;

public static class LanguageExtension
{
	public static IServiceCollection AddLanguage(this IServiceCollection services)
	{
		services.AddSingleton<ISubtitles, PolishSubtitles>();
		return services;
	}
}
