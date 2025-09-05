namespace DesignPatternsConsoleApp.Behavioral.Iterator;

/// <summary>
/// Iterator interface
/// </summary>
public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}
