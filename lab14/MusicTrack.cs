namespace lab14;

internal class MusicTrack
{
    // ---- constructors ----
    public MusicTrack()
    {
        Title = "";
        Artist = "";
        Album = "";
        Genre = "";
        Duration = 0;
    }

    public MusicTrack(string title, string artist, string album, string genre, int duration)
    {
        Title = title;
        Artist = artist;
        Album = album;
        Genre = genre;
        Duration = duration;
    }

    // ---- getters/setters ----
    private string title = "";
    public string Title 
    { 
        get => title;     
        set => title = string.IsNullOrEmpty(value) ? "Unnamed" : value; 
    }

    private string artist = "";
    public string Artist 
    { 
        get => artist;  
        set => artist = string.IsNullOrEmpty(value) ? "Unknown artist" : value;
    }

    private string album = "";
    public string Album
    {
        get => album;
        set => album = string.IsNullOrEmpty(value) ? "Unknown album" : value;
    }

    private string genre = "";
    public string Genre 
    {
        get => genre; 
        set => genre = string.IsNullOrEmpty(value) ? "Unknown genre" : value;
    }

    private int duration; // in seconds
    public int Duration 
    {
        get => duration;
        set => duration = value >= 0 ? value : throw new ArgumentOutOfRangeException("Duration can't be negative value!"); 
    }

    // ---- overrides ----
    public override string ToString()
    {
        return $"{Title} by {Artist} ({Album}, {Genre}, {Duration} sec)";
    }
}
