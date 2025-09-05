namespace DesignPatternsConsoleApp.Creational.AbstractFactory;

/// <summary>
/// Modern furniture family - Concrete products
/// </summary>
public class ModernChair : IChair
{
    public string Name => "Modern Chair";
    
    public void Sit()
    {
        Console.WriteLine("Sitting on a sleek modern chair");
    }
    
    public string GetStyle()
    {
        return "Modern";
    }
}

public class ModernSofa : ISofa
{
    public string Name => "Modern Sofa";
    
    public void Relax()
    {
        Console.WriteLine("Relaxing on a minimalist modern sofa");
    }
    
    public string GetStyle()
    {
        return "Modern";
    }
}

public class ModernTable : ITable
{
    public string Name => "Modern Table";
    
    public void PlaceItems()
    {
        Console.WriteLine("Placing items on a clean modern table");
    }
    
    public string GetStyle()
    {
        return "Modern";
    }
}
