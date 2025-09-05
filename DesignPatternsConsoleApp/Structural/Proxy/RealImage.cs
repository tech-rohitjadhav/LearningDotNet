namespace DesignPatternsConsoleApp.Structural.Proxy;

/// <summary>
/// Real Subject - Real Image
/// </summary>
public class RealImage : IImage
{
    private readonly string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading image from disk: {_filename}");
        // Simulate loading time
        Thread.Sleep(1000);
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {_filename}");
    }
}
