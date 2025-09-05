namespace DesignPatternsConsoleApp.Creational.Prototype;

/// <summary>
/// Concrete prototype - Employee
/// </summary>
public class Employee : ICloneable<Employee>
{
    public string Name { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }
    public List<string> Skills { get; set; } = new();

    public Employee()
    {
    }

    // Copy constructor for deep cloning
    public Employee(Employee other)
    {
        Name = other.Name;
        Department = other.Department;
        Position = other.Position;
        Salary = other.Salary;
        HireDate = other.HireDate;
        Skills = new List<string>(other.Skills); // Deep copy of list
    }

    public Employee Clone()
    {
        return new Employee(this);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Salary: ${Salary:N2}");
        Console.WriteLine($"Hire Date: {HireDate:yyyy-MM-dd}");
        Console.WriteLine($"Skills: {string.Join(", ", Skills)}");
        Console.WriteLine("---");
    }
}
