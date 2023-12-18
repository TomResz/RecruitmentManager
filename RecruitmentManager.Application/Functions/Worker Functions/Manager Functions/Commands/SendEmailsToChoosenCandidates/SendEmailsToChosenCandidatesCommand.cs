using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.SendEmailsToChooseCandidates;

public record SendEmailsToChosenCandidatesCommand(
	Guid JobPostingId,
	List<Guid> CandidateIDs) : IRequest;
