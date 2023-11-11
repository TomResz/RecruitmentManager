using MediatR;
using RecruitmentManager.Application.Error_Serializer;
using RecruitmentManager.Application.Interfaces.Repositories;
using RecruitmentManager.Domain.Entities;
using RecruitmentManager.Shared.Exceptions;

namespace RecruitmentManager.Application.Functions.Candidate_Functions.Commands.Hobbies_action.Edit;

public class EditHobbyCommandHandler
	: IRequestHandler<EditHobbyCommand>
{
	private readonly IAsyncRepository<Hobby> _hobbyRepository;
	public EditHobbyCommandHandler(IAsyncRepository<Hobby> hobbyRepository)
	{
		_hobbyRepository = hobbyRepository;
	}

	public async Task Handle(EditHobbyCommand request, CancellationToken cancellationToken)
	{
		var validation = new EditHobbyCommandValidator();
		var resultOfVal = await validation.ValidateAsync(request, cancellationToken);
		if (!resultOfVal.IsValid)
		{
			throw new BadRequestException(FVErrorSerializer.SerializeToString(
				resultOfVal.Errors));
		}

		var itemToEdit = await _hobbyRepository.GetById(request.HobbyId);
		if (itemToEdit is null)
		{
			throw new NotFoundException("Hobby not found!");
		}

		itemToEdit.Description = request.Description;
		await _hobbyRepository.Update(itemToEdit);
	}
}