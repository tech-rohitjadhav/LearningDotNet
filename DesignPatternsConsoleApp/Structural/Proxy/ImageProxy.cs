namespace DesignPatternsConsoleApp.Structural.Proxy;

/// <summary>
/// Proxy class - Virtual Proxy
/// </summary>
public class ImageProxy : IImage
{
    private readonly string _filename;
    private RealImage? _realImage;

    public ImageProxy(string filename)
    {
        _filename = filename;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            Console.WriteLine($"Creating proxy for image: {_filename}");
            _realImage = new RealImage(_filename);
        }
        _realImage.Display();
    }
}
