namespace DesignPatternsConsoleApp.Creational.Builder;

/// <summary>
/// Product class for Builder pattern
/// </summary>
public class Computer
{
    public string CPU { get; set; } = string.Empty;
    public string RAM { get; set; } = string.Empty;
    public string Storage { get; set; } = string.Empty;
    public string GraphicsCard { get; set; } = string.Empty;
    public string Motherboard { get; set; } = string.Empty;
    public string PowerSupply { get; set; } = string.Empty;
    public List<string> Peripherals { get; set; } = new();

    public void DisplaySpecifications()
    {
        Console.WriteLine("=== Computer Specifications ===");
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage}");
        Console.WriteLine($"Graphics Card: {GraphicsCard}");
        Console.WriteLine($"Motherboard: {Motherboard}");
        Console.WriteLine($"Power Supply: {PowerSupply}");
        
        if (Peripherals.Count > 0)
        {
            Console.WriteLine("Peripherals:");
            foreach (var peripheral in Peripherals)
            {
                Console.WriteLine($"  - {peripheral}");
            }
        }
        Console.WriteLine("===============================");
    }
}
