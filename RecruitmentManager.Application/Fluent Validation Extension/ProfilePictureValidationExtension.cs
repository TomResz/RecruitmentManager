using FluentValidation;

namespace RecruitmentManager.Application.Fluent_Validation_Extension;

public static class ProfilePictureValidationExtension
{
	private const int MaxSizeMb = 2 * 1024 * 1024;
	public static IRuleBuilder<T, byte[]?> ProfilePictureMustBeValid<T>(
		this IRuleBuilder<T, byte[]?> ruleBuilder)
	{
		return ruleBuilder
			.Must(image =>
			{
				if (image is null)
					return true;
				return image.Length <= MaxSizeMb;
			}).WithMessage($"Maksymalny rozmiar wynosi {MaxSizeMb / (1024*1024) }MB");
	}
}