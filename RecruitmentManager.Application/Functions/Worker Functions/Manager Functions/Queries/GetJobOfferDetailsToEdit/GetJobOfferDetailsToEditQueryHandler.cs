using System.Net.NetworkInformation;
using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Interfaces.Repositories;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetJobOfferDetailsToEdit;

public class GetJobOfferDetailsToEditQueryHandler
 : IRequestHandler<GetJobOfferDetailsToEditQuery, JobOfferDetailsToEditDto>
{
	private readonly IJobPostingRepository _jobPostingRepository;
	private readonly IMapper _mapper;
	public GetJobOfferDetailsToEditQueryHandler(
		IJobPostingRepository jobPostingRepository,
		IMapper mapper)
	{
		_jobPostingRepository = jobPostingRepository;
		_mapper = mapper;
	}

	public async Task<JobOfferDetailsToEditDto> Handle(
		GetJobOfferDetailsToEditQuery request,
		CancellationToken cancellationToken)
	{
		var jobOffer = await _jobPostingRepository.GetFullDataByIdAsync(request.id);
		if (jobOffer is null)
			throw new ArgumentNullException(nameof(jobOffer));
		var stages = _mapper.Map<List<RecruitmentStageWithEmployeeDto>>(jobOffer.RecruitmentStages);
		var jobOfferView = _mapper.Map<JobOfferDetailsToEditDto>(jobOffer);

		jobOfferView.RecruitmentStagesDtos = stages.OrderBy(x => x.Order).ToList();
		return jobOfferView;
	}
}