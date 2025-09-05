namespace DesignPatternsConsoleApp.Structural.Bridge;

/// <summary>
/// Concrete Implementor - Raster Renderer
/// </summary>
public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} using raster graphics");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Drawing a square of side {side} using raster graphics");
    }

    public void RenderTriangle(float baseLength, float height)
    {
        Console.WriteLine($"Drawing a triangle with base {baseLength} and height {height} using raster graphics");
    }
}
