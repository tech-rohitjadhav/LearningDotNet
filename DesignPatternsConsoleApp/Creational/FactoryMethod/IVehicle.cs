namespace DesignPatternsConsoleApp.Creational.FactoryMethod;

/// <summary>
/// Product interface for Factory Method pattern
/// </summary>
public interface IVehicle
{
    string Name { get; }
    void Start();
    void Stop();
    void Drive();
}
