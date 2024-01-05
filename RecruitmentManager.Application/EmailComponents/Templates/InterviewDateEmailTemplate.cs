namespace RecruitmentManager.Application.EmailComponents.Templates;

internal class InterviewDateEmailTemplate
{
	public string GetTemplate(
        string jobPostingName,
        string recruitmentStageName, 
        DateTime date)
	{
		string content = $@"<!DOCTYPE html>
            <html lang=""pl"">
            <head>
                <meta charset=""UTF-8"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                <style>
                    .content {{
                        margin-bottom: 25px;
                        font-size: 25px;
                    }}
                    .footer {{
                        margin-top: 45px;
                    }}
                    b {{
                        font-style: italic;
                    }}
                </style>
            </head>
            <body>
                <div class=""content"">
                    <div class=""stage"">
                        Nazwa stanowiska : <b>{jobPostingName}</b>
                    </div>
                    <div class=""stage"">
                        Etap rekrutacji : <b>{recruitmentStageName}</b>
                    </div>
                    <div class=""date"">
                        Data spotkania : <b>{date.ToString("HH:mm dd-MM-yyyy")}</b>
                    </div>
                    <div class=""footer"">
                        Z wyrazmi szacunku:
                        <br>Dział rekrutacji firmy XYZ</br>
                    </div>
                </div>
            </body>
            </html>";
        return content;
	}
}
