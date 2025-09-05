namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// Abstraction for notification services
/// Dependency Inversion Principle: High-level modules should not depend on low-level modules
/// Both should depend on abstractions
/// </summary>
public interface INotificationService
{
    void SendNotification(string message, string recipient);
}
