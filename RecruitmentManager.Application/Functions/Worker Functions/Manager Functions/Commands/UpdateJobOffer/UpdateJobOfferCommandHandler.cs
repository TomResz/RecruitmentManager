using AutoMapper;
using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;

namespace RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Commands.UpdateJobOffer;

public class UpdateJobOfferCommandHandler
: IRequestHandler<UpdateJobOfferCommand>
{
	private readonly IMapper _mapper;
	private readonly IJobPostingRepository _postingRepository;
	public UpdateJobOfferCommandHandler(
		IMapper mapper,
		IJobPostingRepository postingRepository)
	{
		_mapper = mapper;
		_postingRepository = postingRepository;
	}

	public async Task Handle(
		UpdateJobOfferCommand request,
		CancellationToken cancellationToken)
	{
		var validation = new UpdateJobOfferCommandValidation();
		var resultOfValidation = await validation.ValidateAsync(request, cancellationToken);
		if (!resultOfValidation.IsValid)
		{
			throw new ArgumentException(FVErrorSerializer.SerializeToString(
				resultOfValidation.Errors));
		}

		var originalOffer = await _postingRepository.GetFullDataByIdAsync(request.Id);

		if (originalOffer is null)
			throw new ArgumentNullException("Coś poszło nie tak...");

		originalOffer.CreatedDate = request.CreatedDate;
		originalOffer.EndDate = request.EndDate;
		originalOffer.Title = request.Title;
		originalOffer.Description = request.Description;
		originalOffer.NumberOfPositions = request.NumberOfPositions;
		originalOffer.RecruitmentStages = _mapper.Map<List<RecruitmentStage>>(request.StagesToEdit);
		await _postingRepository.UpdateWithRecruitmentStage(originalOffer);
	}
}