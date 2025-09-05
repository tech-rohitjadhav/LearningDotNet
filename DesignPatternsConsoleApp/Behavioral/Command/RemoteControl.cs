namespace DesignPatternsConsoleApp.Behavioral.Command;

/// <summary>
/// Invoker class
/// </summary>
public class RemoteControl
{
    private ICommand? _command;
    private ICommand? _lastCommand;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        if (_command != null)
        {
            _command.Execute();
            _lastCommand = _command;
        }
    }

    public void PressUndo()
    {
        if (_lastCommand != null)
        {
            Console.WriteLine("Undoing last command...");
            _lastCommand.Undo();
        }
    }
}
