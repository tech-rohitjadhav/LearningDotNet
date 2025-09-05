namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// File logger implementation
/// Dependency Inversion Principle: Alternative low-level module implementing same abstraction
/// </summary>
public class FileLogger : ILogger
{
    private readonly string _logFilePath;

    public FileLogger(string logFilePath = "application.log")
    {
        _logFilePath = logFilePath;
    }

    public void Log(string message)
    {
        WriteToFile($"[INFO] {DateTime.Now:HH:mm:ss} - {message}");
    }

    public void LogError(string message)
    {
        WriteToFile($"[ERROR] {DateTime.Now:HH:mm:ss} - {message}");
    }

    public void LogWarning(string message)
    {
        WriteToFile($"[WARNING] {DateTime.Now:HH:mm:ss} - {message}");
    }

    private void WriteToFile(string message)
    {
        // Simulate file writing
        Console.WriteLine($"📄 File Log: {message}");
    }
}
