namespace DesignPatternsConsoleApp.Structural.Bridge;

/// <summary>
/// Implementor interface for Bridge pattern
/// </summary>
public interface IRenderer
{
    void RenderCircle(float radius);
    void RenderSquare(float side);
    void RenderTriangle(float baseLength, float height);
}
