namespace DesignPatternsConsoleApp.Structural.Flyweight;

/// <summary>
/// Context class that uses the flyweight
/// </summary>
public class Tree
{
    private readonly ITreeType _treeType;
    private readonly int _x;
    private readonly int _y;

    public Tree(ITreeType treeType, int x, int y)
    {
        _treeType = treeType;
        _x = x;
        _y = y;
    }

    public void Draw()
    {
        _treeType.Draw(_x, _y);
    }
}
