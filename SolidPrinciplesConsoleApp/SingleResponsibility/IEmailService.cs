namespace SolidPrinciplesConsoleApp.SingleResponsibility;

/// <summary>
/// Interface for email operations
/// Single Responsibility: Only handles email sending
/// </summary>
public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
}
