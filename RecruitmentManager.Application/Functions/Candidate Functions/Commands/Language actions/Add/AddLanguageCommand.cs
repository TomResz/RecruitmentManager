using MediatR;
using RecruitmentManager.Domain.Enums;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Language_actions.Add;

public record AddLanguageCommand(
	string Language,
	LanguageLevel LanguageLevel) : IRequest;