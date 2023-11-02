using FluentValidation;

namespace RecruitmentManager.Application.Fluent_Validation_Extension;

public static class NameValidationExtension
{
	private const string Pattern = "^[A-Za-zĄąĆćĘęŁłŃńÓóŚśŹźŻż]+$";

	public static IRuleBuilder<T,string> NameMustBeValid<T>(this IRuleBuilder<T,string> ruleBuilder,
		string fieldNameToMessage)
	{
		return ruleBuilder
			.NotEmpty().WithMessage($"Puste {fieldNameToMessage}!")
			.Matches(Pattern).WithMessage($"Nieprawidłowe {fieldNameToMessage}!");
	}
}
