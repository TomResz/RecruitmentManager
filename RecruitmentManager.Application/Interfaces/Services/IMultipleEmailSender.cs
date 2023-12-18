namespace RecruitmentManager.Application.Interfaces.Services;

public interface IMultipleEmailSender
{
	Task SendEmailToManyRecipients(List<string> receiverEmail, string subject, string bodyHtml);
}
