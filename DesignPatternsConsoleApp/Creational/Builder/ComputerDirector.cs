namespace DesignPatternsConsoleApp.Creational.Builder;

/// <summary>
/// Director class that orchestrates the building process
/// </summary>
public class ComputerDirector
{
    private readonly IComputerBuilder _builder;

    public ComputerDirector(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public Computer BuildGamingPC()
    {
        Console.WriteLine("Building Gaming PC...");
        return _builder
            .SetCPU("Intel i9-12900K")
            .SetRAM("32GB DDR5")
            .SetStorage("1TB NVMe SSD")
            .SetGraphicsCard("RTX 4080")
            .SetMotherboard("ASUS ROG Strix Z690")
            .SetPowerSupply("850W 80+ Gold")
            .AddPeripheral("Gaming Mouse")
            .AddPeripheral("Mechanical Keyboard")
            .AddPeripheral("Gaming Monitor")
            .Build();
    }

    public Computer BuildOfficePC()
    {
        Console.WriteLine("Building Office PC...");
        return _builder
            .SetCPU("Intel i5-12400")
            .SetRAM("16GB DDR4")
            .SetStorage("512GB SSD")
            .SetGraphicsCard("Integrated Graphics")
            .SetMotherboard("ASUS Prime B660")
            .SetPowerSupply("500W 80+ Bronze")
            .AddPeripheral("Standard Mouse")
            .AddPeripheral("Standard Keyboard")
            .Build();
    }

    public Computer BuildBudgetPC()
    {
        Console.WriteLine("Building Budget PC...");
        return _builder
            .SetCPU("AMD Ryzen 5 5600G")
            .SetRAM("8GB DDR4")
            .SetStorage("256GB SSD")
            .SetGraphicsCard("Integrated Graphics")
            .SetMotherboard("MSI B450M")
            .SetPowerSupply("400W 80+ White")
            .Build();
    }
}
