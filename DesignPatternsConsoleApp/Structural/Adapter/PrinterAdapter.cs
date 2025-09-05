namespace DesignPatternsConsoleApp.Structural.Adapter;

/// <summary>
/// Adapter that makes LegacyPrinter compatible with INewPrinter
/// </summary>
public class PrinterAdapter : INewPrinter
{
    private readonly ILegacyPrinter _legacyPrinter;

    public PrinterAdapter(ILegacyPrinter legacyPrinter)
    {
        _legacyPrinter = legacyPrinter;
    }

    public void Print(string content, string type)
    {
        if (type.ToLower() == "text")
        {
            _legacyPrinter.PrintText(content);
        }
        else if (type.ToLower() == "image")
        {
            _legacyPrinter.PrintImage(content);
        }
        else
        {
            Console.WriteLine($"Unsupported print type: {type}");
        }
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Adapter: Scanning document - {document}");
        // Legacy printer doesn't support scanning, so we simulate it
    }

    public void Copy(string document, int copies)
    {
        Console.WriteLine($"Adapter: Copying document '{document}' {copies} times");
        for (int i = 0; i < copies; i++)
        {
            _legacyPrinter.PrintText($"Copy {i + 1} of {document}");
        }
    }
}
