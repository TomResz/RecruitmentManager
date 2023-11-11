using MediatR;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Update;

public record UpdateLanguageCommand(
	Guid Id,
	string Language,
	LanguageLevel LanguageLevel) : IRequest;