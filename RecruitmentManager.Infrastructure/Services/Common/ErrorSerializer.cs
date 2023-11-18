using FluentValidation.Results;
using RecruitmentManager.Application.Error_Serializer;
using System.Text;

namespace RecruitmentManager.Infrastructure.Services.Common;

public class ErrorSerializer : IErrorSerializer
{
	public string Serialize(List<ValidationFailure> errors)
	{
		var sb = new StringBuilder();
		foreach (var validationResult in errors)
		{
			sb.AppendLine(validationResult.ErrorMessage);
		}
		return sb.ToString();
	}
}