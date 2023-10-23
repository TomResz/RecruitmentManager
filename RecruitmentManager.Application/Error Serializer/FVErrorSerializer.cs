// Ignore Spelling: Serializer

using FluentValidation.Results;
using System.Text;

namespace RecruitmentManager.Application.Error_Serializer;

public static class FVErrorSerializer
{
	public static string SerializeToString(List<ValidationFailure> errors)
	{
		var sb = new StringBuilder();
		foreach (var validationResult in errors)
		{
			sb.AppendLine(validationResult.ErrorMessage);
		}
		return sb.ToString();
	}
}
