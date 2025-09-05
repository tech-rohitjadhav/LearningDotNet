namespace SolidPrinciplesConsoleApp.OpenClosed;

/// <summary>
/// Area calculator that follows Open/Closed Principle
/// Open for extension: Can work with any new shape that implements IShape
/// Closed for modification: No need to modify this class when adding new shapes
/// </summary>
public class AreaCalculator
{
    public double CalculateTotalArea(List<IShape> shapes)
    {
        double totalArea = 0;
        
        foreach (var shape in shapes)
        {
            totalArea += shape.CalculateArea();
            Console.WriteLine($"{shape.GetShapeType()}: {shape.CalculateArea():F2} square units");
        }
        
        return totalArea;
    }

    public void DisplayShapeInfo(IShape shape)
    {
        Console.WriteLine($"Shape: {shape.GetShapeType()}");
        Console.WriteLine($"Area: {shape.CalculateArea():F2} square units");
        Console.WriteLine("---");
    }
}
