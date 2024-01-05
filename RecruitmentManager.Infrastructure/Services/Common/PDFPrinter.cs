using iTextSharp.text;
using iTextSharp.text.pdf;
using RecruitmentManager.Application.Functions.DTOs;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetListOfSelectedCandidates;
using RecruitmentManager.Application.Functions.Worker_Functions.Manager_Functions.Queries.GetStatisticsOfJobPosting;
using RecruitmentManager.Application.Interfaces.Services;
using RecruitmentManager.Domain.Entities;


namespace RecruitmentManager.Infrastructure.Services.Common;

public class PDFPrinter : IPdfPrinter
{
	public void Print(string fullPath,
		StatisticsOfJobPostingResponse statistics,
		List<EvaluatedCandidateDto> candidates,
		JobPosting jobPosting,
		List<CandidateResponse> candidateResponses)
	{
		using FileStream filestream = new FileStream(fullPath, FileMode.OpenOrCreate);

		Document document = new Document(PageSize.A4, 15f, 15f, 35f, 25f);
		using var writer = PdfWriter.GetInstance(document, filestream);
		var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1257, BaseFont.NOT_EMBEDDED);
		var fontPara = new Font(baseFont, 12, Font.NORMAL);
		var fontBoldPara = new Font(baseFont, 12, Font.BOLD);
		var fontHeader = new Font(baseFont, 20, Font.BOLD);
		var tableHeader = new Font(baseFont, 13, Font.BOLD);

		document.Open();

		var paragraph = new Paragraph();

		paragraph = new Paragraph(DateTime.Now.ToString("HH:mm dd-MM-yyyy"), fontPara);
		paragraph.Alignment = Element.ALIGN_RIGHT;
		document.Add(paragraph);

		paragraph = new Paragraph("Raport", fontHeader);
		paragraph.Alignment = Element.ALIGN_CENTER;
		document.Add(paragraph);


		paragraph = new Paragraph(" ", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		paragraph.SpacingBefore = 10f;
		document.Add(paragraph);

		paragraph = new Paragraph($"Nazwa oferty pracy: {jobPosting.Title}", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		document.Add(paragraph);


		paragraph = new Paragraph($"Ilość etapów rekrutacyjnych: {jobPosting.RecruitmentStages.Count()}", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		document.Add(paragraph);

		paragraph = new Paragraph($"Ilość miejsc: {jobPosting.NumberOfPositions}", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		paragraph.SpacingAfter = 10f;
		document.Add(paragraph);



		paragraph = new Paragraph($"Ilość zgłoszeń: {statistics.TotalNumberOfApplications}", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		document.Add(paragraph);


		paragraph = new Paragraph($"Ilość rezygnacji: {statistics.TotalNumberOfResignation}", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		document.Add(paragraph);

		paragraph = new Paragraph($"Ilość zakwalifikowanych kandydatów do rozmowy: {statistics.TotalNumberOfQualified}/{statistics.TotalNumberOfApplications}", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		document.Add(paragraph);


		paragraph = new Paragraph($"Ilość odbytych rozmów kwalifikacyjnych: {statistics.TotalNumberOfInterviewsHeld}/{statistics.TotalNumberOfInterview}", fontPara);
		paragraph.Alignment = Element.ALIGN_LEFT;
		document.Add(paragraph);

		if (candidates.Count is not 0)
		{
			paragraph = new Paragraph("Kandydaci i ich średnie ważone:", fontBoldPara);
			paragraph.SpacingBefore = 10f;
			paragraph.Alignment = Element.ALIGN_CENTER;
			document.Add(paragraph);

			paragraph = new Paragraph("", fontPara);
			paragraph.SpacingBefore = 10f;
			paragraph.Alignment = Element.ALIGN_CENTER;
			document.Add(paragraph);

			var table = new PdfPTable(3);
			table.DefaultCell.PaddingBottom = 5;
			table.WidthPercentage = 100;
			table.AddCell(new Phrase("Nr", tableHeader));
			table.AddCell(new Phrase("Imię i Nazwisko", tableHeader));
			table.AddCell(new Phrase("Średnia Ważona", tableHeader));

			foreach (var candidate in candidates)
			{
				table.AddCell(new Phrase(candidate.Position.ToString(), fontPara));
				table.AddCell(new Phrase(candidate.FullName, fontPara));
				table.AddCell(new Phrase(candidate.AverageGrade.ToString(), fontPara));
			}
			document.Add(table);
		}
		else
		{
			paragraph = new Paragraph("Brak ocenionych kandydatów!", fontBoldPara);
			paragraph.Alignment = Element.ALIGN_LEFT;
			document.Add(paragraph);
		}


		if(candidateResponses.Count is not 0)
		{
			paragraph = new Paragraph("Wybrani kandydaci:", fontBoldPara);
			paragraph.SpacingBefore = 15f;
			paragraph.SpacingAfter = 10f;
			paragraph.Alignment = Element.ALIGN_CENTER;
			document.Add(paragraph);

			var table = new PdfPTable(1);
			table.DefaultCell.PaddingBottom = 5;
			table.WidthPercentage = 100;
			table.AddCell(new Phrase("Imię i Nazwisko", tableHeader));

			foreach (var candidate in candidateResponses)
			{
				table.AddCell(new Phrase(candidate.FullName, fontPara));
			}
			document.Add(table);
		}
		document.Close();
	}
}
