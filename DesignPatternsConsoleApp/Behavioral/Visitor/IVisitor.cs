namespace DesignPatternsConsoleApp.Behavioral.Visitor;

/// <summary>
/// Visitor interface
/// </summary>
public interface IVisitor
{
    void Visit(Book book);
    void Visit(Electronics electronics);
    void Visit(Clothing clothing);
}
