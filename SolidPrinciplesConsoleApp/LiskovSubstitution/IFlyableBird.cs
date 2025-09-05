namespace SolidPrinciplesConsoleApp.LiskovSubstitution;

/// <summary>
/// Interface for birds that can fly
/// Liskov Substitution Principle: Separate flying behavior from basic bird behavior
/// </summary>
public interface IFlyableBird : IBird
{
    void Fly();
    double MaxFlightDistance { get; }
}
