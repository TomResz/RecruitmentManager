using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Queries.GetJobPostingWhereDidNotApply;

public class GetActiveJobPostingWhereDidNotApplyCommandHandler
	: IRequestHandler<GetActiveJobPostingWhereDidNotApplyCommand,List<JobOffersViewDto>>
{
	private readonly IJobPostingRepository _jobPostingRepository;
	private readonly IMapper _mapper;
	public GetActiveJobPostingWhereDidNotApplyCommandHandler(
		IJobPostingRepository jobPostingRepository,
		IMapper mapper)
	{
		_jobPostingRepository = jobPostingRepository;
		_mapper = mapper;
	}

	public async Task<List<JobOffersViewDto>> Handle(
		GetActiveJobPostingWhereDidNotApplyCommand request,
		CancellationToken cancellationToken)
	{
		var list = await _jobPostingRepository.GetWithJobApplicationWhereDidNotApply(
			request.CandidateId);
		var activeJobPostings = list.Where(x => 
			x.CreatedDate <= DateTime.Now && x.EndDate > DateTime.Now);
		return _mapper.Map<List<JobOffersViewDto>>(activeJobPostings);
	}
}