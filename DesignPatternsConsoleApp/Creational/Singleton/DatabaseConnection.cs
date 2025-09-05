namespace DesignPatternsConsoleApp.Creational.Singleton;

/// <summary>
/// Singleton Pattern - Thread-Safe Implementation
/// Ensures a class has only one instance and provides global access to it
/// Real-life example: Database connection, Logger, Configuration manager
/// </summary>
public sealed class DatabaseConnection
{
    private static DatabaseConnection? _instance;
    private static readonly object _lock = new object();
    private readonly string _connectionString;
    private readonly DateTime _createdAt;

    // Private constructor prevents external instantiation
    private DatabaseConnection()
    {
        _connectionString = "Server=localhost;Database=MyApp;Trusted_Connection=true;";
        _createdAt = DateTime.UtcNow;
        Console.WriteLine($"Database connection created at {_createdAt:HH:mm:ss}");
    }

    // Public static method to get the single instance
    public static DatabaseConnection GetInstance()
    {
        // Double-checked locking pattern for thread safety
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
            }
        }
        return _instance;
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Executing query: {query}");
        Console.WriteLine($"Using connection: {_connectionString}");
    }

    public void CloseConnection()
    {
        Console.WriteLine("Closing database connection");
    }

    // Properties to demonstrate singleton behavior
    public string ConnectionString => _connectionString;
    public DateTime CreatedAt => _createdAt;
}
