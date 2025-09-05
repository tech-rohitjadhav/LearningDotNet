namespace DesignPatternsConsoleApp.Creational.Prototype;

/// <summary>
/// Registry/Manager for prototypes
/// </summary>
public class EmployeeRegistry
{
    private readonly Dictionary<string, Employee> _prototypes = new();

    public void RegisterPrototype(string key, Employee employee)
    {
        _prototypes[key] = employee;
        Console.WriteLine($"Registered prototype: {key}");
    }

    public Employee CreateEmployee(string key)
    {
        if (_prototypes.TryGetValue(key, out var prototype))
        {
            Console.WriteLine($"Creating employee from prototype: {key}");
            return prototype.Clone();
        }
        else
        {
            throw new ArgumentException($"Prototype '{key}' not found");
        }
    }

    public void ListPrototypes()
    {
        Console.WriteLine("Available prototypes:");
        foreach (var kvp in _prototypes)
        {
            Console.WriteLine($"  - {kvp.Key}");
        }
    }
}
