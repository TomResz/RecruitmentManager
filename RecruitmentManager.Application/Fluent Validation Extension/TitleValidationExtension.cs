using FluentValidation;

namespace RecruitmentManager.Application.Fluent_Validation_Extension;

public static class TitleValidationExtension
{
	public static IRuleBuilder<T, string> TitleMustBeValid<T>(this IRuleBuilder<T, string> ruleBuilder)
	{
		return ruleBuilder
			.NotEmpty().WithMessage("Tytuł nie może być pusty!")
			.MaximumLength(100).WithMessage("Przekroczono długość tytułu (100 znaków)!");
	}
}