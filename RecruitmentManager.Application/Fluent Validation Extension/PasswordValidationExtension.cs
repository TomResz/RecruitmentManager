using FluentValidation;

namespace RecruitmentManager.Application.Fluent_Validation_Extension;

public static class PasswordValidationExtension
{
	public static IRuleBuilder<T,string> PasswordMustBeValid<T>(this IRuleBuilder<T,string> ruleBuilder)
	{
		return ruleBuilder
			.NotEmpty().WithMessage("Hasło nie może być puste!")
			.MinimumLength(8).WithMessage("Niepoprawna długość hasła!");
	}
}
