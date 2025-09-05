namespace DesignPatternsConsoleApp.Creational.AbstractFactory;

/// <summary>
/// Abstract Factory interface
/// </summary>
public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ITable CreateTable();
}

/// <summary>
/// Concrete factory for Modern furniture
/// </summary>
public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}

/// <summary>
/// Concrete factory for Victorian furniture
/// </summary>
public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }

    public ITable CreateTable()
    {
        return new VictorianTable();
    }
}
