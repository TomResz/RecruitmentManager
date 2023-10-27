using Microsoft.Extensions.DependencyInjection;
using RecruitmentManager.Subtitles;
using System.Globalization;

namespace RecruitmentManager.DI;

public static class LanguageExtension
{
	public static IServiceCollection AddLanguage(this IServiceCollection services)
	{
		if (CultureInfo.CurrentCulture.Name == "pl-PL")
		{
			services.AddSingleton<ISubtitles, PolishSubtitles>();
		}
		else
		{
			services.AddSingleton<ISubtitles,EnglishSubtitles>();
		}
		return services;
	}
}
