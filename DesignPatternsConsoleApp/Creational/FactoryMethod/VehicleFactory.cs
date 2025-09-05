namespace DesignPatternsConsoleApp.Creational.FactoryMethod;

/// <summary>
/// Creator abstract class for Factory Method pattern
/// </summary>
public abstract class VehicleFactory
{
    // Factory method - to be implemented by subclasses
    public abstract IVehicle CreateVehicle();

    // Template method that uses the factory method
    public void ManufactureVehicle()
    {
        Console.WriteLine("Starting vehicle manufacturing process...");
        
        var vehicle = CreateVehicle();
        
        Console.WriteLine($"Manufacturing {vehicle.Name}...");
        vehicle.Start();
        vehicle.Drive();
        vehicle.Stop();
        
        Console.WriteLine($"{vehicle.Name} manufacturing completed!");
    }
}

/// <summary>
/// Concrete creator - Car Factory
/// </summary>
public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}

/// <summary>
/// Concrete creator - Motorcycle Factory
/// </summary>
public class MotorcycleFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Motorcycle();
    }
}

/// <summary>
/// Concrete creator - Truck Factory
/// </summary>
public class TruckFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Truck();
    }
}
