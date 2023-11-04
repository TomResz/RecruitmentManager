namespace RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries.GetJobOfferDetails;

public record GetJobOfferDetailsResponse(
	string Title,
	string Description,
	DateTime CreatedDate,
	DateTime EndDate,
	int NumberOfPlaces);