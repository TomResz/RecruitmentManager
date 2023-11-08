using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingsWhereApply;

public class GetJobPostingsWhereCandidateApplyCommandHandler
	: IRequestHandler<GetJobPostingsWhereCandidateApplyCommand, List<JobOffersWhereCandidateAppliedViewDto>>
{
	private readonly IMapper _mapper;
	private readonly IJobPostingRepository _jobPostingRepository;

	public GetJobPostingsWhereCandidateApplyCommandHandler(
		IMapper mapper,
		IJobPostingRepository jobPostingRepository)
	{
		_mapper = mapper;
		_jobPostingRepository = jobPostingRepository;
	}

	public async Task<List<JobOffersWhereCandidateAppliedViewDto>> Handle(
		GetJobPostingsWhereCandidateApplyCommand request,
		CancellationToken cancellationToken)
	{
		var list = await _jobPostingRepository.GetWithJobApplicationWhereApply(request.CandidateId);
		var response = _mapper.Map<List<JobOffersWhereCandidateAppliedViewDto>>(list);
		return response;
	}
}