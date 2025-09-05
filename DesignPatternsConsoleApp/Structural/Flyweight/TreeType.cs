namespace DesignPatternsConsoleApp.Structural.Flyweight;

/// <summary>
/// Concrete Flyweight
/// </summary>
public class TreeType : ITreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
        Console.WriteLine($"Creating new TreeType: {name} ({color}, {texture})");
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing {Name} tree at position ({x}, {y}) with {Color} color and {Texture} texture");
    }
}
