namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// Email notification service implementation
/// Dependency Inversion Principle: Low-level module implementing abstraction
/// </summary>
public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message, string recipient)
    {
        Console.WriteLine($"📧 Email sent to {recipient}: {message}");
    }
}
