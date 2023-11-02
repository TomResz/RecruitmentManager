using FluentValidation;

namespace RecruitmentManager.Application.Fluent_Validation_Extension;

public static class DescriptionValidationExtension
{
	public static IRuleBuilder<T,string> DescriptionMustBeValid<T>(
		this IRuleBuilder<T,string> ruleBuilder)
	{

		return ruleBuilder
			.NotEmpty().WithMessage("Opis nie może być pusty!")
			.MaximumLength(1500).WithMessage("Przekroczono maskymalną długość opisu (1000 znaków)!");
	}
}