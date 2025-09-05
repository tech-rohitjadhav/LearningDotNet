namespace DesignPatternsConsoleApp.Creational.AbstractFactory;

/// <summary>
/// Abstract product interfaces for Abstract Factory pattern
/// </summary>
public interface IChair
{
    string Name { get; }
    void Sit();
    string GetStyle();
}

public interface ISofa
{
    string Name { get; }
    void Relax();
    string GetStyle();
}

public interface ITable
{
    string Name { get; }
    void PlaceItems();
    string GetStyle();
}
