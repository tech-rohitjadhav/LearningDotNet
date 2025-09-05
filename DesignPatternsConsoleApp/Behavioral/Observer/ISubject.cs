namespace DesignPatternsConsoleApp.Behavioral.Observer;

/// <summary>
/// Subject interface
/// </summary>
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
}
