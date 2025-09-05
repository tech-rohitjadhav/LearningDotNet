namespace SolidPrinciplesConsoleApp.InterfaceSegregation;

/// <summary>
/// Workplace that demonstrates Interface Segregation Principle
/// Different types of workers are handled appropriately based on their capabilities
/// </summary>
public class Workplace
{
    private readonly List<IWorker> _workers = new();
    private readonly List<IManager> _managers = new();

    public void AddWorker(IWorker worker)
    {
        _workers.Add(worker);
        Console.WriteLine($"Added worker: {worker.Name}");
    }

    public void AddManager(IManager manager)
    {
        _managers.Add(manager);
        _workers.Add(manager); // Managers are also workers
        Console.WriteLine($"Added manager: {manager.Name}");
    }

    public void StartWorkDay()
    {
        Console.WriteLine("\n--- Starting work day ---");
        
        // All workers work
        foreach (var worker in _workers)
        {
            worker.Work();
        }

        // Managers manage
        foreach (var manager in _managers)
        {
            manager.Manage();
        }
    }

    public void LunchBreak()
    {
        Console.WriteLine("\n--- Lunch break ---");
        
        // Only workers who can eat will eat
        foreach (var worker in _workers)
        {
            if (worker is IEater eater)
            {
                eater.Eat();
            }
        }
    }

    public void EndWorkDay()
    {
        Console.WriteLine("\n--- End of work day ---");
        
        // Only workers who can sleep will sleep
        foreach (var worker in _workers)
        {
            if (worker is ISleeper sleeper)
            {
                sleeper.Sleep();
            }
        }
    }

    public void AssignTasks()
    {
        Console.WriteLine("\n--- Task assignment ---");
        
        foreach (var manager in _managers)
        {
            foreach (var worker in _workers.Where(w => w != manager))
            {
                manager.AssignTask(worker, $"Task from {manager.Name}");
            }
        }
    }
}
