namespace DesignPatternsConsoleApp.Behavioral.TemplateMethod;

/// <summary>
/// Abstract class with template method
/// </summary>
public abstract class DataProcessor
{
    // Template method - defines the algorithm structure
    public void ProcessData()
    {
        Console.WriteLine("Starting data processing...");
        
        ReadData();
        ProcessDataInternal();
        ValidateData();
        SaveData();
        
        Console.WriteLine("Data processing completed!");
        Console.WriteLine();
    }

    // Concrete steps that are common to all implementations
    protected virtual void ReadData()
    {
        Console.WriteLine("Reading data from source...");
    }

    protected virtual void ValidateData()
    {
        Console.WriteLine("Validating data...");
    }

    protected virtual void SaveData()
    {
        Console.WriteLine("Saving processed data...");
    }

    // Abstract method that must be implemented by subclasses
    protected abstract void ProcessDataInternal();
}

/// <summary>
/// Concrete implementation - CSV Data Processor
/// </summary>
public class CsvDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading CSV file...");
    }

    protected override void ProcessDataInternal()
    {
        Console.WriteLine("Processing CSV data - parsing rows and columns...");
    }

    protected override void SaveData()
    {
        Console.WriteLine("Saving processed data to database...");
    }
}

/// <summary>
/// Concrete implementation - XML Data Processor
/// </summary>
public class XmlDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading XML file...");
    }

    protected override void ProcessDataInternal()
    {
        Console.WriteLine("Processing XML data - parsing elements and attributes...");
    }

    protected override void SaveData()
    {
        Console.WriteLine("Saving processed data to JSON file...");
    }
}
