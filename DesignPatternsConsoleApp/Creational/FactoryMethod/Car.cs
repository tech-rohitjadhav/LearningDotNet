namespace DesignPatternsConsoleApp.Creational.FactoryMethod;

/// <summary>
/// Concrete product - Car
/// </summary>
public class Car : IVehicle
{
    public string Name => "Car";

    public void Start()
    {
        Console.WriteLine("Car engine started");
    }

    public void Stop()
    {
        Console.WriteLine("Car engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine("Driving on the road");
    }
}
