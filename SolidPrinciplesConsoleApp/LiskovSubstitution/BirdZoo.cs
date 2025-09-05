namespace SolidPrinciplesConsoleApp.LiskovSubstitution;

/// <summary>
/// Bird zoo that demonstrates Liskov Substitution Principle
/// All bird types can be substituted without breaking functionality
/// </summary>
public class BirdZoo
{
    private readonly List<IBird> _birds = new();

    public void AddBird(IBird bird)
    {
        _birds.Add(bird);
        Console.WriteLine($"Added {bird.Name} to the zoo");
    }

    public void FeedAllBirds()
    {
        Console.WriteLine("\n--- Feeding all birds ---");
        foreach (var bird in _birds)
        {
            bird.Eat();
        }
    }

    public void PutAllBirdsToSleep()
    {
        Console.WriteLine("\n--- Putting all birds to sleep ---");
        foreach (var bird in _birds)
        {
            bird.Sleep();
        }
    }

    public void LetFlyableBirdsFly()
    {
        Console.WriteLine("\n--- Letting flyable birds fly ---");
        foreach (var bird in _birds)
        {
            if (bird is IFlyableBird flyableBird)
            {
                flyableBird.Fly();
                Console.WriteLine($"Max flight distance: {flyableBird.MaxFlightDistance} km");
            }
        }
    }

    public void LetSwimmableBirdsSwim()
    {
        Console.WriteLine("\n--- Letting swimmable birds swim ---");
        foreach (var bird in _birds)
        {
            if (bird is ISwimmableBird swimmableBird)
            {
                swimmableBird.Swim();
                Console.WriteLine($"Max swim depth: {swimmableBird.MaxSwimDepth} meters");
            }
        }
    }
}
