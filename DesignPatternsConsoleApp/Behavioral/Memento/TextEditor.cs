namespace DesignPatternsConsoleApp.Behavioral.Memento;

/// <summary>
/// Originator class
/// </summary>
public class TextEditor
{
    private string _content = string.Empty;

    public string Content
    {
        get => _content;
        set
        {
            _content = value;
            Console.WriteLine($"Content updated: {_content}");
        }
    }

    public IMemento Save()
    {
        return new TextMemento(_content);
    }

    public void Restore(IMemento memento)
    {
        if (memento is TextMemento textMemento)
        {
            _content = textMemento.GetState();
            Console.WriteLine($"Content restored to: {_content}");
        }
    }
}

/// <summary>
/// Concrete Memento
/// </summary>
public class TextMemento : IMemento
{
    private readonly string _state;
    private readonly DateTime _date;

    public TextMemento(string state)
    {
        _state = state;
        _date = DateTime.Now;
    }

    public string GetState()
    {
        return _state;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}
