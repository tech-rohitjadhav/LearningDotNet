namespace DesignPatternsConsoleApp.Behavioral.Iterator;

/// <summary>
/// Concrete Collection
/// </summary>
public class Playlist : ICollection<Song>
{
    private readonly List<Song> _songs = new();

    public int Count => _songs.Count;

    public Song this[int index] => _songs[index];

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }

    public IIterator<Song> CreateIterator()
    {
        return new PlaylistIterator(this);
    }
}

/// <summary>
/// Concrete Iterator
/// </summary>
public class PlaylistIterator : IIterator<Song>
{
    private readonly Playlist _playlist;
    private int _currentIndex = 0;

    public PlaylistIterator(Playlist playlist)
    {
        _playlist = playlist;
    }

    public bool HasNext()
    {
        return _currentIndex < _playlist.Count;
    }

    public Song Next()
    {
        if (HasNext())
        {
            var song = _playlist[_currentIndex];
            _currentIndex++;
            return song;
        }
        throw new InvalidOperationException("No more songs in playlist");
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}

/// <summary>
/// Song class
/// </summary>
public class Song
{
    public string Title { get; }
    public string Artist { get; }
    public TimeSpan Duration { get; }

    public Song(string title, string artist, TimeSpan duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"{Title} by {Artist} ({Duration:mm\\:ss})";
    }
}
