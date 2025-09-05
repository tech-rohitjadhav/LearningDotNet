namespace DesignPatternsConsoleApp.Behavioral.Memento;

/// <summary>
/// Caretaker class
/// </summary>
public class Caretaker
{
    private readonly List<IMemento> _mementos = new();
    private readonly TextEditor _textEditor;

    public Caretaker(TextEditor textEditor)
    {
        _textEditor = textEditor;
    }

    public void Save()
    {
        var memento = _textEditor.Save();
        _mementos.Add(memento);
        Console.WriteLine($"Save point created at {memento.GetDate():HH:mm:ss}");
    }

    public void Undo()
    {
        if (_mementos.Count > 0)
        {
            var memento = _mementos.Last();
            _mementos.RemoveAt(_mementos.Count - 1);
            _textEditor.Restore(memento);
        }
        else
        {
            Console.WriteLine("No save points available to undo");
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Save history:");
        for (int i = 0; i < _mementos.Count; i++)
        {
            var memento = _mementos[i];
            Console.WriteLine($"  {i + 1}. {memento.GetState()} (saved at {memento.GetDate():HH:mm:ss})");
        }
    }
}
