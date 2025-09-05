namespace SolidPrinciplesConsoleApp.OpenClosed;

/// <summary>
/// Circle shape implementation
/// Open/Closed Principle: Extends IShape without modifying existing code
/// </summary>
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public string GetShapeType()
    {
        return "Circle";
    }
}
