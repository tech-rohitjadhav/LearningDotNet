namespace DesignPatternsConsoleApp.Structural.Bridge;

/// <summary>
/// Concrete Implementor - Vector Renderer
/// </summary>
public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} using vector graphics");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Drawing a square of side {side} using vector graphics");
    }

    public void RenderTriangle(float baseLength, float height)
    {
        Console.WriteLine($"Drawing a triangle with base {baseLength} and height {height} using vector graphics");
    }
}
