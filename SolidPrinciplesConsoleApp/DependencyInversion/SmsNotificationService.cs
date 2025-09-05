namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// SMS notification service implementation
/// Dependency Inversion Principle: Alternative low-level module implementing same abstraction
/// </summary>
public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message, string recipient)
    {
        Console.WriteLine($"📱 SMS sent to {recipient}: {message}");
    }
}
