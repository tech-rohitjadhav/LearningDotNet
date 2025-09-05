namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Interface for managers - separate from basic worker functionality
/// Interface Segregation Principle: Management responsibilities are separate from basic work
/// </summary>
public interface IManager : IWorker
{
    void Manage();
    void AssignTask(IWorker worker, string task);
}
