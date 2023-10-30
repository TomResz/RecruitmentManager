using FluentValidation;

namespace RecruitmentManager.Application.Fluent_Validation_Extension;

public static class EmailValidationExtension
{
	private static string pattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"; 
	public static IRuleBuilder<T,string> EmailMustBeValid<T>(this IRuleBuilder<T,string> ruleBuilder)
	{
		return ruleBuilder
			.NotEmpty().WithMessage("Pusty adres email!")
			.Matches(pattern).WithMessage("Niepoprawny adres email!");
	}
}
