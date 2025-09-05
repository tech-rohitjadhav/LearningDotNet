namespace DesignPatternsConsoleApp.Structural.Decorator;

/// <summary>
/// Concrete component - Simple Coffee
/// </summary>
public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 2.00;
    }
}
