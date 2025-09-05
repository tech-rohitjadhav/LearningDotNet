namespace SolidPrinciplesConsoleApp.DependencyInversion;

/// <summary>
/// Abstraction for logging services
/// Dependency Inversion Principle: Depend on abstractions, not concretions
/// </summary>
public interface ILogger
{
    void Log(string message);
    void LogError(string message);
    void LogWarning(string message);
}
