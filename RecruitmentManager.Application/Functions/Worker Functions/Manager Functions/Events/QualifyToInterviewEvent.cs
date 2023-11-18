using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events;

public record QualifyToInterviewEvent(
	Guid CandidateId,
	Guid JobPostingId) : INotification;