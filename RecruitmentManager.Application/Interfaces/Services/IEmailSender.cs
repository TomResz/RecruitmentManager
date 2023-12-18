namespace RecruitmentManager.Application.Interfaces.Services;

public interface IEmailSender
{
	Task SendEmail(string receiverEmail,string subject,string bodyHtml);
}
