namespace DesignPatternsConsoleApp.Behavioral.Mediator;

/// <summary>
/// Mediator interface
/// </summary>
public interface IChatMediator
{
    void SendMessage(string message, IUser user);
    void AddUser(IUser user);
}
