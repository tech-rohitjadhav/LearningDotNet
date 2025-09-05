namespace DesignPatternsConsoleApp.Structural.Adapter;

/// <summary>
/// Legacy interface that needs to be adapted
/// </summary>
public interface ILegacyPrinter
{
    void PrintText(string text);
    void PrintImage(string imagePath);
}
