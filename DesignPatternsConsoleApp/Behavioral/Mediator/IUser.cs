namespace DesignPatternsConsoleApp.Behavioral.Mediator;

/// <summary>
/// Colleague interface
/// </summary>
public interface IUser
{
    string Name { get; }
    void SendMessage(string message);
    void ReceiveMessage(string message, string senderName);
}
