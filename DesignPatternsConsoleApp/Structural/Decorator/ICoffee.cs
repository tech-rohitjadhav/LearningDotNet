namespace DesignPatternsConsoleApp.Structural.Decorator;

/// <summary>
/// Component interface for Decorator pattern
/// </summary>
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}
