namespace SolidPrinciplesConsoleApp.LiskovSubstitution;

/// <summary>
/// Duck implementation - can both fly and swim
/// Liskov Substitution Principle: Can be substituted for IBird, IFlyableBird, and ISwimmableBird
/// </summary>
public class Duck : IFlyableBird, ISwimmableBird
{
    public string Name { get; }
    public double MaxFlightDistance { get; }
    public double MaxSwimDepth { get; }

    public Duck(string name)
    {
        Name = name;
        MaxFlightDistance = 100; // km
        MaxSwimDepth = 5; // meters
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} the Duck is eating plants and small insects");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the Duck is sleeping on the water");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} the Duck is flying in a V-formation");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} the Duck is swimming and diving for food");
    }
}
