namespace SolidPrinciplesConsoleApp.LiskovSubstitution;

/// <summary>
/// Eagle implementation - can fly
/// Liskov Substitution Principle: Can be substituted for IBird and IFlyableBird
/// </summary>
public class Eagle : IFlyableBird
{
    public string Name { get; }
    public double MaxFlightDistance { get; }

    public Eagle(string name)
    {
        Name = name;
        MaxFlightDistance = 1000; // km
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} the Eagle is eating small mammals and fish");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the Eagle is sleeping in its nest");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} the Eagle is soaring high in the sky");
    }
}
