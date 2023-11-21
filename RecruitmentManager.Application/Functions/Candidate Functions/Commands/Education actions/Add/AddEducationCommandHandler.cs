using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Education_actions.Add;

public class AddEducationCommandHandler
	: IRequestHandler<AddEducationCommand>
{
	private readonly IEducationRepository _educationRepository;
	private readonly ICandidateSessionContext _candidateSessionContext;
	private readonly IErrorSerializer _errorSerializer;
	public AddEducationCommandHandler(IEducationRepository educationRepository, 
		ICandidateSessionContext candidateSessionContext,
		IErrorSerializer errorSerializer)
	{
		_educationRepository = educationRepository;
		_candidateSessionContext = candidateSessionContext;
		_errorSerializer = errorSerializer;
	}

	public async Task Handle(AddEducationCommand request, CancellationToken cancellationToken)
	{
		var validator = new AddEducationCommandValidator();
		var result = await validator.ValidateAsync(request, cancellationToken);
		if (!result.IsValid)
		{
			throw new BadRequestException(_errorSerializer.Serialize(result.Errors));
		}

		var education = new Education
		{
			Id = Guid.NewGuid(),
			CandidateId = _candidateSessionContext.CandidateId ?? throw new 
				("Authorization error!"),
			DateOfCompletion = request.End ,
			IsCompleted = request.End is not null,
			Major = request.Major,
			StartDate = request.Start,
			LevelOfEducationId = request.LevelOfEducationId,
			SchoolName = request.SchoolName
		};
		await _educationRepository.Add(education);
	}
}