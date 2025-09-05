namespace DesignPatternsConsoleApp.Behavioral.Mediator;

/// <summary>
/// Concrete Mediator
/// </summary>
public class ChatMediator : IChatMediator
{
    private readonly List<IUser> _users = new();

    public void AddUser(IUser user)
    {
        _users.Add(user);
        Console.WriteLine($"User {user.Name} joined the chat");
    }

    public void SendMessage(string message, IUser sender)
    {
        Console.WriteLine($"{sender.Name} sends: {message}");
        
        foreach (var user in _users)
        {
            if (user != sender)
            {
                user.ReceiveMessage(message, sender.Name);
            }
        }
    }
}
