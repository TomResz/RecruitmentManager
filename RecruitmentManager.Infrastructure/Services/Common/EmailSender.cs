using RecruitmentManager.Application.Interfaces.Services;
using System.Net.Mail;

namespace RecruitmentManager.Infrastructure.Services.Common;

public class EmailSender : 
	IEmailSender
{
	private readonly SmtpClient _smtpClient;

	public EmailSender(SmtpClient smtpClient)
	{
		_smtpClient = smtpClient;
	}

	public async Task SendEmail(string receiverEmail, string subject, string bodyHtml)
	{
		var mailMessage = new MailMessage
		{
			From = new MailAddress("dzial.rekrutacji.firmy.xyz@gmail.com"),
			Subject = subject,
			Body = bodyHtml,
			IsBodyHtml = true,
		};
		mailMessage.To.Add(receiverEmail);
		await _smtpClient.SendMailAsync(mailMessage);
	}

	public async Task SendEmailToManyRecipients(List<string> receiverEmail, string subject, string bodyHtml)
	{

	}
}
