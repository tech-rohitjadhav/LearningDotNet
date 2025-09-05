namespace DesignPatternsConsoleApp.Behavioral.Observer;

/// <summary>
/// Concrete Observer - News Channel
/// </summary>
public class NewsChannel : IObserver
{
    public string Name { get; }

    public NewsChannel(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"[{Name}] Breaking News: {message}");
    }
}
