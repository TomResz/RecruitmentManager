using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SelectCandidatesToWork;

internal sealed class SelectCandidatesToWorkCommandHandler
	: IRequestHandler<SelectCandidatesToWorkCommand>
{
	private readonly ISelectedCandidatesToJobRepository _repository;

	public SelectCandidatesToWorkCommandHandler(ISelectedCandidatesToJobRepository repository)
	{
		_repository = repository;
	}

	public async Task Handle(SelectCandidatesToWorkCommand request, CancellationToken cancellationToken)
	{
		var list = new List<SelectedCandidatesToJob>();

		foreach (var candidateId in request.CandidateIDs)
		{
			list.Add(new SelectedCandidatesToJob
			{
				Id = Guid.NewGuid(),
				JobPostingId = request.JobPostingId,
				CandidateId = candidateId
			});
		}
		await _repository.Add(list);
	}
}
