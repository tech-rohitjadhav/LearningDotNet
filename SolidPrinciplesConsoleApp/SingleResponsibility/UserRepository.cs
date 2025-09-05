namespace SolidPrinciplesConsoleApp.SingleResponsibility;

/// <summary>
/// User repository implementation
/// Single Responsibility: Only handles user data persistence operations
/// </summary>
public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new();
    private int _nextId = 1;

    public void Save(User user)
    {
        if (user.Id == 0)
        {
            user.Id = _nextId++;
        }
        
        var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            _users.Remove(existingUser);
        }
        
        _users.Add(user);
        Console.WriteLine($"User {user.Name} saved to repository");
    }

    public User? GetById(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            Console.WriteLine($"Retrieved user: {user.Name} from repository");
        }
        return user;
    }

    public void Delete(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            _users.Remove(user);
            Console.WriteLine($"User {user.Name} deleted from repository");
        }
    }
}
