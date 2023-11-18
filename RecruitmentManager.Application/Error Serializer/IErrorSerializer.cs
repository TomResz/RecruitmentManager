using FluentValidation.Results;

namespace RecruitmentManager.Application.Error_Serializer;

public interface IErrorSerializer
{
	string Serialize(List<ValidationFailure> errors);
}