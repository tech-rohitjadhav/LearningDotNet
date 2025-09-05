namespace DesignPatternsConsoleApp.Behavioral.ChainOfResponsibility;

/// <summary>
/// Handler interface
/// </summary>
public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void Handle(Request request);
}
