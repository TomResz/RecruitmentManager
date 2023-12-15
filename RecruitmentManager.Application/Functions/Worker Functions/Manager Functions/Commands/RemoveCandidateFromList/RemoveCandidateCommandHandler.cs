using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.RemoveCandidateFromList;

internal sealed class RemoveCandidateCommandHandler
	: IRequestHandler<RemoveCandidateCommand>
{
	private readonly ISelectedCandidatesToJobRepository _selectedCandidatesToJobRepository;

	public RemoveCandidateCommandHandler(ISelectedCandidatesToJobRepository selectedCandidatesToJobRepository)
	{
		_selectedCandidatesToJobRepository = selectedCandidatesToJobRepository;
	}

	public async Task Handle(RemoveCandidateCommand request, CancellationToken cancellationToken)
	{
		await _selectedCandidatesToJobRepository.Remove(request.JobPostingId);
	}
}
