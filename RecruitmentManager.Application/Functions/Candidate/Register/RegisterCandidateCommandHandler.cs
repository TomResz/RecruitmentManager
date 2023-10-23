using MediatR;
using RecruitmentManager.Application.Error_Serializer;

namespace RecruitmentManager.Application.Functions.Candidate.Register;

public class RegisterCandidateCommandHandler
    : IRequestHandler<RegisterCandidateCommand>
{
    public async Task Handle(
        RegisterCandidateCommand request,
        CancellationToken cancellationToken)
    {
        var validation = new RegisterCandidateValidation();
        var result = await validation.ValidateAsync(request, cancellationToken);
        if (!result.IsValid)
        {
            throw new InvalidDataException(
                FVErrorSerializer.SerializeToString(result.Errors));
        }
    }
}
