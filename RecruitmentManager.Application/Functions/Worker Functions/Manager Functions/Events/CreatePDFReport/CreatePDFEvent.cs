using MediatR;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Events.CreatePDFReport;

public record CreatePDFEvent(
	Guid JobPostingId,
	string FullPath) : IRequest;
