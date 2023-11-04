using MediatR;
using RecruitmentManager.Application.Functions.Worker_Functions.Common.Queries.GetJobOfferDetails;
using RecruitmentManager.Application.Interfaces.Context;

namespace RecruitmentManager.Forms.Common;

public partial class ShowJobOfferDetailsForm : Form
{
	private readonly IJobOfferContext _jobOfferContext;
	private readonly IMediator _mediator;
	public ShowJobOfferDetailsForm(
		IMediator mediator,
		IJobOfferContext jobOfferContext)
	{
		_mediator = mediator;
		_jobOfferContext = jobOfferContext;
		InitializeComponent();
		titleTextBox.ReadOnly = true;
		descriptionTextBox.ReadOnly = true;
		this.Load += LoadPage;
		InitializePictureBoxesActions();
	}

	private void InitializePictureBoxesActions()
	{
		titlePB.MouseHover += (
			s,
			args) => toolTip1.Show("Nazwa stanowiska", titlePB);
		descriptionPB.MouseHover += (
			s,
			args) => toolTip1.Show("Opis ogłoszenia", descriptionPB);
		beginDatePB.MouseHover += (
			s,
			args) => toolTip1.Show("Data zamieszczenia ogłoszenia", beginDatePB);
		endDatePB.MouseHover += (
			s,
			args) => toolTip1.Show("Data zakończenia ogłoszenia", endDatePB);
		numberOfPlacesPB.MouseHover += (
			s,
			args) => toolTip1.Show("Ilość miejsc na dane stanowisko", numberOfPlacesPB);
	}
	private async void LoadPage(object? sender, EventArgs e)
	{
		var details = await _mediator.Send(new GetJobOfferDetailsQuery(_jobOfferContext.Id));
		titleTextBox.Text = details.Title;
		descriptionTextBox.Text = details.Description;
		countLabel.Text = details.NumberOfPlaces.ToString();
		beginDateLabel.Text = details.CreatedDate.ToString("HH:mm   dd/MM/yyyy");
		endDateLabel.Text = details.EndDate.ToString("HH:mm   dd/MM/yyyy");
	}
}