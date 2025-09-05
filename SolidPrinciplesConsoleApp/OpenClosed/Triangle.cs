namespace SolidPrinciplesConsoleApp.OpenClosed;

/// <summary>
/// Triangle shape implementation
/// Open/Closed Principle: New shape added without modifying existing code
/// </summary>
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public string GetShapeType()
    {
        return "Triangle";
    }
}
