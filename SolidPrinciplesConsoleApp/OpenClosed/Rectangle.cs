namespace SolidPrinciplesConsoleApp.OpenClosed;

/// <summary>
/// Rectangle shape implementation
/// Open/Closed Principle: Extends IShape without modifying existing code
/// </summary>
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public string GetShapeType()
    {
        return "Rectangle";
    }
}
