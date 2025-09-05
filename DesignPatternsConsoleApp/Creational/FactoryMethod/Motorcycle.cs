namespace DesignPatternsConsoleApp.Creational.FactoryMethod;

/// <summary>
/// Concrete product - Motorcycle
/// </summary>
public class Motorcycle : IVehicle
{
    public string Name => "Motorcycle";

    public void Start()
    {
        Console.WriteLine("Motorcycle engine started");
    }

    public void Stop()
    {
        Console.WriteLine("Motorcycle engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine("Riding on the road");
    }
}
