namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Human worker implementation
/// Interface Segregation Principle: Implements only the interfaces it needs
/// Humans can work, eat, and sleep
/// </summary>
public class HumanWorker : IWorker, IEater, ISleeper
{
    public string Name { get; }

    public HumanWorker(string name)
    {
        Name = name;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is working on assigned tasks");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating lunch");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping at night");
    }
}
