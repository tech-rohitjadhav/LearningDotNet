namespace DesignPatternsConsoleApp.Structural.Composite;

/// <summary>
/// Leaf class - File
/// </summary>
public class File : IFileSystemComponent
{
    public string Name { get; }
    public int Size { get; }

    public File(string name, int size)
    {
        Name = name;
        Size = size;
    }

    public void Display(int depth = 0)
    {
        var indent = new string(' ', depth * 2);
        Console.WriteLine($"{indent}📄 {Name} ({Size} bytes)");
    }
}
