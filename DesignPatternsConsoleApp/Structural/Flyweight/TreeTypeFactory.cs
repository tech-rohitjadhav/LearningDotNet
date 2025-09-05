namespace DesignPatternsConsoleApp.Structural.Flyweight;

/// <summary>
/// Flyweight Factory
/// </summary>
public class TreeTypeFactory
{
    private readonly Dictionary<string, ITreeType> _treeTypes = new();

    public ITreeType GetTreeType(string name, string color, string texture)
    {
        var key = $"{name}_{color}_{texture}";
        
        if (!_treeTypes.ContainsKey(key))
        {
            _treeTypes[key] = new TreeType(name, color, texture);
        }
        else
        {
            Console.WriteLine($"Reusing existing TreeType: {name} ({color}, {texture})");
        }
        
        return _treeTypes[key];
    }

    public int GetTreeTypeCount()
    {
        return _treeTypes.Count;
    }
}
