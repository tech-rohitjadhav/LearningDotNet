namespace SolidPrinciplesConsoleApp.OpenClosed;

/// <summary>
/// Base interface for all shapes
/// Open/Closed Principle: Open for extension, closed for modification
/// New shapes can be added without modifying existing code
/// </summary>
public interface IShape
{
    double CalculateArea();
    string GetShapeType();
}
