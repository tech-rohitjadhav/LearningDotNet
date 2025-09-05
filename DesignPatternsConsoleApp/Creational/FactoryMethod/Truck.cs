namespace DesignPatternsConsoleApp.Creational.FactoryMethod;

/// <summary>
/// Concrete product - Truck
/// </summary>
public class Truck : IVehicle
{
    public string Name => "Truck";

    public void Start()
    {
        Console.WriteLine("Truck engine started");
    }

    public void Stop()
    {
        Console.WriteLine("Truck engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine("Driving heavy load on the road");
    }
}
