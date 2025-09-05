namespace DesignPatternsConsoleApp.Structural.Flyweight;

/// <summary>
/// Flyweight interface
/// </summary>
public interface ITreeType
{
    string Name { get; }
    string Color { get; }
    string Texture { get; }
    void Draw(int x, int y);
}
