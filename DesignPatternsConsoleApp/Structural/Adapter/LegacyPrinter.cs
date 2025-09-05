namespace DesignPatternsConsoleApp.Structural.Adapter;

/// <summary>
/// Legacy printer implementation
/// </summary>
public class LegacyPrinter : ILegacyPrinter
{
    public void PrintText(string text)
    {
        Console.WriteLine($"Legacy Printer: Printing text - {text}");
    }

    public void PrintImage(string imagePath)
    {
        Console.WriteLine($"Legacy Printer: Printing image from - {imagePath}");
    }
}
