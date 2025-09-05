namespace SolidPrinciplesConsoleApp.SingleResponsibility;

/// <summary>
/// Email service implementation
/// Single Responsibility: Only handles email sending operations
/// </summary>
public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        // Simulate email sending
        Console.WriteLine($"Email sent to: {to}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body: {body}");
        Console.WriteLine("---");
    }
}
