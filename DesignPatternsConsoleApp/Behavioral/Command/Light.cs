namespace DesignPatternsConsoleApp.Behavioral.Command;

/// <summary>
/// Receiver class
/// </summary>
public class Light
{
    private bool _isOn = false;

    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine("Light is ON");
    }

    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine("Light is OFF");
    }

    public bool IsOn => _isOn;
}
