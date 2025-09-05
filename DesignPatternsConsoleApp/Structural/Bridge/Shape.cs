namespace DesignPatternsConsoleApp.Structural.Bridge;

/// <summary>
/// Abstraction for Bridge pattern
/// </summary>
public abstract class Shape
{
    protected IRenderer _renderer;

    protected Shape(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public abstract void Draw();
}

/// <summary>
/// Refined Abstraction - Circle
/// </summary>
public class Circle : Shape
{
    private float _radius;

    public Circle(IRenderer renderer, float radius) : base(renderer)
    {
        _radius = radius;
    }

    public override void Draw()
    {
        _renderer.RenderCircle(_radius);
    }
}

/// <summary>
/// Refined Abstraction - Square
/// </summary>
public class Square : Shape
{
    private float _side;

    public Square(IRenderer renderer, float side) : base(renderer)
    {
        _side = side;
    }

    public override void Draw()
    {
        _renderer.RenderSquare(_side);
    }
}
