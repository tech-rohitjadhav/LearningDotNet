namespace DesignPatternsConsoleApp.Behavioral.Iterator;

/// <summary>
/// Collection interface
/// </summary>
public interface ICollection<T>
{
    IIterator<T> CreateIterator();
    int Count { get; }
    T this[int index] { get; }
}
