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
	private readonly IErrorSerializer _errorSerializer;
	public EditHobbyCommandHandler(IAsyncRepository<Hobby> hobbyRepository, 
		IErrorSerializer errorSerializer)
	{
		_hobbyRepository = hobbyRepository;
		_errorSerializer = errorSerializer;
	}

	public async Task Handle(EditHobbyCommand request, CancellationToken cancellationToken)
	{
		var validation = new EditHobbyCommandValidator();
		var resultOfVal = await validation.ValidateAsync(request, cancellationToken);
		if (!resultOfVal.IsValid)
		{
			throw new BadRequestException(_errorSerializer.Serialize(resultOfVal.Errors));
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