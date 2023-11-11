using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities.Candidate_Elements;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Experience_actions.Update;

public class UpdateExperienceCommandHandler
	: IRequestHandler<UpdateExperienceCommand>
{
	private readonly IAsyncRepository<Experience> _experienceRepository;

	public UpdateExperienceCommandHandler(IAsyncRepository<Experience> experienceRepository)
	{
		_experienceRepository = experienceRepository;
	}

	public async Task Handle(UpdateExperienceCommand request, CancellationToken cancellationToken)
	{
		var item = await _experienceRepository.GetById(request.Id);
		if (item is null)
		{
			throw new NotFoundException(nameof(item));
		}
		item.CompanyName = request.CompanyName;
		item.JobName = request.Title;
		item.StartDateOfWork = request.Start;
		item.OfCompletionOfWork = request.End;
		item.Description = request.Description;
		await _experienceRepository.Update(item);
	}
}