namespace DesignPatternsConsoleApp.Creational.Builder;

/// <summary>
/// Builder interface
/// </summary>
public interface IComputerBuilder
{
    IComputerBuilder SetCPU(string cpu);
    IComputerBuilder SetRAM(string ram);
    IComputerBuilder SetStorage(string storage);
    IComputerBuilder SetGraphicsCard(string graphicsCard);
    IComputerBuilder SetMotherboard(string motherboard);
    IComputerBuilder SetPowerSupply(string powerSupply);
    IComputerBuilder AddPeripheral(string peripheral);
    Computer Build();
}
