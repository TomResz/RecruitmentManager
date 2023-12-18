using RecruitmentManager.Application.Interfaces.Services;
using System.Net.Mail;

namespace RecruitmentManager.Infrastructure.Services.Common;

public class MultipleEmailSender : IMultipleEmailSender
{
	private readonly SmtpClient _smtpClient;

	public MultipleEmailSender(SmtpClient smtpClient)
	{
		_smtpClient = smtpClient;
	}

	public async Task SendEmailToManyRecipients(List<string> receiverEmail, string subject, string bodyHtml)
	{
		var mailMessage = new MailMessage
		{
			From = new MailAddress("dzial.rekrutacji.firmy.xyz@gmail.com"),
			Subject = subject,
			Body = bodyHtml,
			IsBodyHtml = true,
		};
		foreach (var receiver in receiverEmail)
		{
			mailMessage.To.Add(receiver);

		}
		await _smtpClient.SendMailAsync(mailMessage);
	}
}
