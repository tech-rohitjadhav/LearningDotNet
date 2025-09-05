namespace DesignPatternsConsoleApp.Structural.Composite;

/// <summary>
/// Component interface for Composite pattern
/// </summary>
public interface IFileSystemComponent
{
    string Name { get; }
    int Size { get; }
    void Display(int depth = 0);
}
