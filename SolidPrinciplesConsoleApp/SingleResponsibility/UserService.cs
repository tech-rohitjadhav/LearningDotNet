namespace SolidPrinciplesConsoleApp.SingleResponsibility;

/// <summary>
/// User service - Single Responsibility: Only handles user business logic
/// This class demonstrates SRP by separating concerns:
/// - User business logic (this class)
/// - Data persistence (UserRepository)
/// - Email operations (EmailService)
/// </summary>
public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IEmailService _emailService;

    public UserService(IUserRepository userRepository, IEmailService emailService)
    {
        _userRepository = userRepository;
        _emailService = emailService;
    }

    public void RegisterUser(string name, string email)
    {
        // Business logic: Create user
        var user = new User(name, email);
        
        // Delegate data persistence to repository
        _userRepository.Save(user);
        
        // Delegate email sending to email service
        _emailService.SendEmail(
            email, 
            "Welcome!", 
            $"Welcome {name}! Your account has been created successfully."
        );
        
        Console.WriteLine($"User {name} registered successfully!");
    }

    public void DeleteUser(int userId)
    {
        var user = _userRepository.GetById(userId);
        if (user != null)
        {
            _userRepository.Delete(userId);
            _emailService.SendEmail(
                user.Email,
                "Account Deleted",
                $"Hello {user.Name}, your account has been deleted."
            );
        }
    }
}
