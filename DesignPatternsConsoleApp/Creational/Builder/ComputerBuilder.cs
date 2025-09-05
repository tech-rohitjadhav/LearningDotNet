namespace DesignPatternsConsoleApp.Creational.Builder;

/// <summary>
/// Concrete Builder implementation
/// </summary>
public class ComputerBuilder : IComputerBuilder
{
    private Computer _computer = new();

    public IComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        Console.WriteLine($"Setting CPU: {cpu}");
        return this;
    }

    public IComputerBuilder SetRAM(string ram)
    {
        _computer.RAM = ram;
        Console.WriteLine($"Setting RAM: {ram}");
        return this;
    }

    public IComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        Console.WriteLine($"Setting Storage: {storage}");
        return this;
    }

    public IComputerBuilder SetGraphicsCard(string graphicsCard)
    {
        _computer.GraphicsCard = graphicsCard;
        Console.WriteLine($"Setting Graphics Card: {graphicsCard}");
        return this;
    }

    public IComputerBuilder SetMotherboard(string motherboard)
    {
        _computer.Motherboard = motherboard;
        Console.WriteLine($"Setting Motherboard: {motherboard}");
        return this;
    }

    public IComputerBuilder SetPowerSupply(string powerSupply)
    {
        _computer.PowerSupply = powerSupply;
        Console.WriteLine($"Setting Power Supply: {powerSupply}");
        return this;
    }

    public IComputerBuilder AddPeripheral(string peripheral)
    {
        _computer.Peripherals.Add(peripheral);
        Console.WriteLine($"Adding Peripheral: {peripheral}");
        return this;
    }

    public Computer Build()
    {
        Console.WriteLine("Building computer...");
        var builtComputer = _computer;
        _computer = new Computer(); // Reset for next build
        return builtComputer;
    }
}
