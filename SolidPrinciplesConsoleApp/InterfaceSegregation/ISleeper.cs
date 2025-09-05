namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Interface for entities that can sleep
/// Interface Segregation Principle: Separate sleeping behavior from working behavior
/// </summary>
public interface ISleeper
{
    void Sleep();
}
