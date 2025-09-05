namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// Console logger implementation
/// Dependency Inversion Principle: Low-level module implementing abstraction
/// </summary>
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now:HH:mm:ss} - {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now:HH:mm:ss} - {message}");
    }

    public void LogWarning(string message)
    {
        Console.WriteLine($"[WARNING] {DateTime.Now:HH:mm:ss} - {message}");
    }
}
