using FluentValidation;

namespace RecruitmentManager.Application.Fluent_Validation_Extension;

public static class PhoneNumberValidationExtension
{
	private const string Pattern = @"(\+\d{2}\d{2})?\d{9}";

	public static IRuleBuilder<T,string> PhoneNumberMustBeValid<T>(this IRuleBuilder<T,string> ruleBuilder)
	{
		return ruleBuilder
			.NotEmpty().WithMessage("Pusty numer telefonu!")
			.Matches(Pattern).WithMessage("Nieprawidłowy numer telefonu!");
	}
}
