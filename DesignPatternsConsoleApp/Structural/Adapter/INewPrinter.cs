namespace DesignPatternsConsoleApp.Structural.Adapter;

/// <summary>
/// New interface that we want to use
/// </summary>
public interface INewPrinter
{
    void Print(string content, string type);
    void Scan(string document);
    void Copy(string document, int copies);
}
