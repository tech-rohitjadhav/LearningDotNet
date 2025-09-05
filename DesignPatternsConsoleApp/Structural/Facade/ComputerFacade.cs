namespace DesignPatternsConsoleApp.Structural.Facade;

/// <summary>
/// Facade class that provides a simplified interface to the complex subsystem
/// </summary>
public class ComputerFacade
{
    private readonly CPU _cpu;
    private readonly Memory _memory;
    private readonly HardDrive _hardDrive;
    private readonly GraphicsCard _graphicsCard;

    public ComputerFacade()
    {
        _cpu = new CPU();
        _memory = new Memory();
        _hardDrive = new HardDrive();
        _graphicsCard = new GraphicsCard();
    }

    public void StartComputer()
    {
        Console.WriteLine("=== Starting Computer ===");
        _cpu.Start();
        _memory.Load();
        _hardDrive.SpinUp();
        _graphicsCard.Initialize();
        Console.WriteLine("Computer started successfully!");
        Console.WriteLine();
    }

    public void RunApplication()
    {
        Console.WriteLine("=== Running Application ===");
        _memory.Allocate();
        _hardDrive.Read();
        _cpu.Execute();
        _graphicsCard.Render();
        Console.WriteLine("Application running!");
        Console.WriteLine();
    }

    public void ShutdownComputer()
    {
        Console.WriteLine("=== Shutting Down Computer ===");
        _graphicsCard.Shutdown();
        _hardDrive.Write();
        _memory.Free();
        _cpu.Shutdown();
        Console.WriteLine("Computer shut down successfully!");
        Console.WriteLine();
    }
}
