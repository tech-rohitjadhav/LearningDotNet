namespace DesignPatternsConsoleApp.Creational.Singleton;

/// <summary>
/// Singleton Pattern - Alternative Implementation using Lazy<T>
/// Modern C# approach for thread-safe singleton
/// </summary>
public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
    private readonly List<string> _logs = new();

    private Logger()
    {
        Console.WriteLine("Logger instance created");
    }

    public static Logger Instance => _instance.Value;

    public void Log(string message)
    {
        var logEntry = $"[{DateTime.Now:HH:mm:ss}] {message}";
        _logs.Add(logEntry);
        Console.WriteLine(logEntry);
    }

    public void LogError(string message)
    {
        var logEntry = $"[{DateTime.Now:HH:mm:ss}] ERROR: {message}";
        _logs.Add(logEntry);
        Console.WriteLine(logEntry);
    }

    public List<string> GetAllLogs()
    {
        return new List<string>(_logs);
    }

    public void ClearLogs()
    {
        _logs.Clear();
        Console.WriteLine("All logs cleared");
    }
}
