namespace SolidPrinciplesConsoleApp.LiskovSubstitution;

/// <summary>
/// Interface for birds that can swim
/// Liskov Substitution Principle: Separate swimming behavior from basic bird behavior
/// </summary>
public interface ISwimmableBird : IBird
{
    void Swim();
    double MaxSwimDepth { get; }
}
