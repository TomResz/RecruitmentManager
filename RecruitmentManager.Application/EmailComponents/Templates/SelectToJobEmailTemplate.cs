namespace RecruitmentManager.Application.EmailComponents.Templates;

internal class SelectToJobEmailTemplate
{
	public string GetTemplate(string jobName)
	{
        string emailTemplate = $@"
    <!DOCTYPE html>
    <html lang=""pl"">
    <head>
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <title>SelectedCandidate</title>
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
            <div class=""gratings"">
                Gratulacje otrzymałeś pracę: <b>{jobName}</b>
            </div>
            <div class=""footer"">
                Z wyrazmi szacunku:
                <br>Dział rekrutacji firmy XYZ</br>
            </div>
        </div>
    </body>
    </html>";

		return emailTemplate;
	}
}
