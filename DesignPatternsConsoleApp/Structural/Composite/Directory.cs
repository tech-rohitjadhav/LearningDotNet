namespace DesignPatternsConsoleApp.Structural.Composite;

/// <summary>
/// Composite class - Directory
/// </summary>
public class Directory : IFileSystemComponent
{
    public string Name { get; }
    private readonly List<IFileSystemComponent> _children = new();

    public Directory(string name)
    {
        Name = name;
    }

    public int Size
    {
        get
        {
            return _children.Sum(child => child.Size);
        }
    }

    public void Add(IFileSystemComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IFileSystemComponent component)
    {
        _children.Remove(component);
    }

    public void Display(int depth = 0)
    {
        var indent = new string(' ', depth * 2);
        Console.WriteLine($"{indent}📁 {Name} ({Size} bytes)");
        
        foreach (var child in _children)
        {
            child.Display(depth + 1);
        }
    }
}
