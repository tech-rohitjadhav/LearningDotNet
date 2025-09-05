namespace DesignPatternsConsoleApp.Behavioral.Observer;

/// <summary>
/// Concrete Subject - News Agency
/// </summary>
public class NewsAgency : ISubject
{
    private readonly List<IObserver> _observers = new();
    private string _latestNews = string.Empty;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine($"Observer attached: {observer.GetType().Name}");
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine($"Observer detached: {observer.GetType().Name}");
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Notifying {_observers.Count} observers...");
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }

    public void PublishNews(string news)
    {
        _latestNews = news;
        Console.WriteLine($"News Agency published: {news}");
        Notify(news);
    }

    public string GetLatestNews()
    {
        return _latestNews;
    }
}
