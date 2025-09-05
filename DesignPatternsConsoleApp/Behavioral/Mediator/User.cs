namespace DesignPatternsConsoleApp.Behavioral.Mediator;

/// <summary>
/// Concrete Colleague
/// </summary>
public class User : IUser
{
    public string Name { get; }
    private readonly IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public void SendMessage(string message)
    {
        _mediator.SendMessage(message, this);
    }

    public void ReceiveMessage(string message, string senderName)
    {
        Console.WriteLine($"{Name} received from {senderName}: {message}");
    }
}
