namespace SolidPrinciplesConsoleApp.LiskovSubstitution;

/// <summary>
/// Penguin implementation - can swim but cannot fly
/// Liskov Substitution Principle: Can be substituted for IBird and ISwimmableBird
/// Note: Does NOT implement IFlyableBird because penguins cannot fly
/// </summary>
public class Penguin : ISwimmableBird
{
    public string Name { get; }
    public double MaxSwimDepth { get; }

    public Penguin(string name)
    {
        Name = name;
        MaxSwimDepth = 500; // meters
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} the Penguin is eating fish and krill");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} the Penguin is sleeping on the ice");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} the Penguin is swimming gracefully underwater");
    }
}
