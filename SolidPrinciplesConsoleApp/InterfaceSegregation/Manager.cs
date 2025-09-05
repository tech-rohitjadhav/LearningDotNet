namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Manager implementation
/// Interface Segregation Principle: Implements only the interfaces it needs
/// Managers can work, eat, sleep, and manage
/// </summary>
public class Manager : IWorker, IEater, ISleeper, IManager
{
    public string Name { get; }

    public Manager(string name)
    {
        Name = name;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is managing the team");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating in the executive dining room");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping (managers need rest too!)");
    }

    public void Manage()
    {
        Console.WriteLine($"{Name} is overseeing operations and making decisions");
    }

    public void AssignTask(IWorker worker, string task)
    {
        Console.WriteLine($"{Name} assigned task '{task}' to {worker.Name}");
    }
}
