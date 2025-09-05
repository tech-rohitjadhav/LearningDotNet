namespace DesignPatternsConsoleApp.Behavioral.Memento;

/// <summary>
/// Memento interface
/// </summary>
public interface IMemento
{
    string GetState();
    DateTime GetDate();
}
