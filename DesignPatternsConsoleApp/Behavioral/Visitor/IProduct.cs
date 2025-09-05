namespace DesignPatternsConsoleApp.Behavioral.Visitor;

/// <summary>
/// Element interface
/// </summary>
public interface IProduct
{
    string Name { get; }
    decimal Price { get; }
    void Accept(IVisitor visitor);
}
