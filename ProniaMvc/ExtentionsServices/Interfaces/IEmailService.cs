namespace ProniaMvc.ExtentionsServices.Interfaces;

public interface IEmailService
{
    void Send(string toMail, string subject, string message, bool isBodyHtml = true);
}
