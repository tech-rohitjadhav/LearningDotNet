namespace DesignPatternsConsoleApp.Structural.Facade;

/// <summary>
/// Subsystem classes that are complex and need to be simplified
/// </summary>
public class CPU
{
    public void Start()
    {
        Console.WriteLine("CPU: Starting up...");
    }

    public void Execute()
    {
        Console.WriteLine("CPU: Executing instructions...");
    }

    public void Shutdown()
    {
        Console.WriteLine("CPU: Shutting down...");
    }
}

public class Memory
{
    public void Load()
    {
        Console.WriteLine("Memory: Loading data...");
    }

    public void Allocate()
    {
        Console.WriteLine("Memory: Allocating memory blocks...");
    }

    public void Free()
    {
        Console.WriteLine("Memory: Freeing memory...");
    }
}

public class HardDrive
{
    public void Read()
    {
        Console.WriteLine("Hard Drive: Reading data...");
    }

    public void Write()
    {
        Console.WriteLine("Hard Drive: Writing data...");
    }

    public void SpinUp()
    {
        Console.WriteLine("Hard Drive: Spinning up...");
    }
}

public class GraphicsCard
{
    public void Initialize()
    {
        Console.WriteLine("Graphics Card: Initializing...");
    }

    public void Render()
    {
        Console.WriteLine("Graphics Card: Rendering graphics...");
    }

    public void Shutdown()
    {
        Console.WriteLine("Graphics Card: Shutting down...");
    }
}
