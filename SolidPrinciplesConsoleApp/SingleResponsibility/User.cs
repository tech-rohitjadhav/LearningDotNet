namespace SolidPrinciplesConsoleApp.SingleResponsibility;

/// <summary>
/// User entity - Single Responsibility: Only represents user data
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
        CreatedAt = DateTime.UtcNow;
    }
}
