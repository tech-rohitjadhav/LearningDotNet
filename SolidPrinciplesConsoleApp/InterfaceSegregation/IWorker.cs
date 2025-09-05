namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Basic worker interface - only essential worker functionality
/// Interface Segregation Principle: Clients should not depend on interfaces they don't use
/// </summary>
public interface IWorker
{
    string Name { get; }
    void Work();
}
