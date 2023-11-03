using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Context;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.CreateJobOffer;

public class CreateJobOfferCommandHandler
	: IRequestHandler<CreateJobOfferCommand>
{
	private readonly IMapper _mapper;
	private readonly IWorkerSessionContext _workerSessionContext;
	private readonly IJobPostingRepository _jobPostingRepository;
	public CreateJobOfferCommandHandler(
		IMapper mapper,
		IWorkerSessionContext workerSessionContext,
		IJobPostingRepository jobPostingRepository)
	{
		_mapper = mapper;
		_workerSessionContext = workerSessionContext;
		_jobPostingRepository = jobPostingRepository;
	}

	public async Task Handle(
		CreateJobOfferCommand request,
		CancellationToken cancellationToken)
	{
		var validation = new CreateJobOfferCommandValidation();
		var resultOfValidation = await validation.ValidateAsync(request, cancellationToken);
		if (!resultOfValidation.IsValid)
		{
			throw new ArgumentException(FVErrorSerializer
				.SerializeToString(resultOfValidation.Errors));
		}

		Guid workerId = _workerSessionContext.WorkerId 
		                ?? throw new InvalidDataException(nameof(_workerSessionContext.WorkerId));

		var stages = _mapper.Map<List<RecruitmentStage>>(request.RecruitmentStagesDtos);
		var jobOffer = new JobPosting()
		{
			Id = Guid.NewGuid(),
			EmployeeId = workerId,
			CreatedDate = request.CreatedDate,
			Title = request.Title,
			Description = request.Description,
			EndDate = request.EndDate,
			NumberOfPositions = request.NumberOfPositions,
			RecruitmentStages = stages
		};
		await _jobPostingRepository.AddAsync(jobOffer);
	}
}