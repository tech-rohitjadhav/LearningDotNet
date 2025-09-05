namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Interface for entities that can eat
/// Interface Segregation Principle: Separate eating behavior from working behavior
/// </summary>
public interface IEater
{
    void Eat();
}
