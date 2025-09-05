namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Robot worker implementation
/// Interface Segregation Principle: Implements only the interfaces it needs
/// Robots can work but don't eat or sleep
/// </summary>
public class RobotWorker : IWorker
{
    public string Name { get; }

    public RobotWorker(string name)
    {
        Name = name;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is performing automated tasks");
    }
}
