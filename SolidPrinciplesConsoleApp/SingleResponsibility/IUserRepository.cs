namespace SolidPrinciplesConsoleApp.SingleResponsibility;

/// <summary>
/// Interface for user data operations
/// Single Responsibility: Only handles user data persistence
/// </summary>
public interface IUserRepository
{
    void Save(User user);
    User? GetById(int id);
    void Delete(int id);
}
