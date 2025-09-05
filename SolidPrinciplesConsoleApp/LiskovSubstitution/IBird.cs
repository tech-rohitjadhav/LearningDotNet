namespace SolidPrinciplesConsoleApp.LiskovSubstitution;

/// <summary>
/// Base interface for birds
/// Liskov Substitution Principle: All implementations should be substitutable
/// </summary>
public interface IBird
{
    string Name { get; }
    void Eat();
    void Sleep();
}
