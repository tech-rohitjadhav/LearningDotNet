namespace DesignPatternsConsoleApp.Creational.AbstractFactory;

/// <summary>
/// Victorian furniture family - Concrete products
/// </summary>
public class VictorianChair : IChair
{
    public string Name => "Victorian Chair";
    
    public void Sit()
    {
        Console.WriteLine("Sitting on an ornate Victorian chair");
    }
    
    public string GetStyle()
    {
        return "Victorian";
    }
}

public class VictorianSofa : ISofa
{
    public string Name => "Victorian Sofa";
    
    public void Relax()
    {
        Console.WriteLine("Relaxing on a luxurious Victorian sofa");
    }
    
    public string GetStyle()
    {
        return "Victorian";
    }
}

public class VictorianTable : ITable
{
    public string Name => "Victorian Table";
    
    public void PlaceItems()
    {
        Console.WriteLine("Placing items on an elegant Victorian table");
    }
    
    public string GetStyle()
    {
        return "Victorian";
    }
}
